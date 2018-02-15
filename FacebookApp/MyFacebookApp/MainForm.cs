using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using HoroscopeController;
using FriendsController;

namespace MyFacebookApp
{
    public partial class MainForm : Form
    {
        public enum eFrinedsListChoice
        {
            RegularOrder,
            FirstNameOrder,
            LastNameOrder
        }

        private enum eEventsType
        {
            Attending,
            Maybe,
            NotRepliad,
            NotAttending
        }

        private readonly LoginForm r_LoginForm = new LoginForm();
        private readonly CheckInOnMapForm r_CheckInsOnMapForm = new CheckInOnMapForm();
        private readonly CreateNewAlbumForm r_CreateNewAlbumForm = new CreateNewAlbumForm();
        private readonly PlaylistForm r_PlaylistForm = new PlaylistForm();
        private readonly PartnerZodiacSignForm r_PartnerSignForm = new PartnerZodiacSignForm();
        private readonly SetBirthdayForm r_SetBirthdayForm = new SetBirthdayForm();
        private readonly FriendsFacade r_FriendsFacade = new FriendsFacade();
        private ZodiacSign m_UserZodiacSign = null;
        private User m_LoggedInUser;
        private string m_UserPartnerSign = null;
        private eFrinedsListChoice m_CurrentChoice = eFrinedsListChoice.RegularOrder;
        private FacebookObjectCollection<Event> m_CurrentEvents;
        private bool m_PostFetch = false;
 
        public MainForm()
        {
            InitializeComponent();

            if (r_LoginForm.ShowDialog() == DialogResult.OK)
            {
                if (r_LoginForm.LoginResult.LoggedInUser != null)
                {
                    m_LoggedInUser = r_LoginForm.LoginResult.LoggedInUser;
                    new Thread(updateInfo).Start();
                }
                else
                {
                    Environment.Exit(0);
                }
            }
            else
            {
                Environment.Exit(0);
            }
        }

        private void mainForm_Load(object i_Sender, EventArgs i_EventArgs)
        {
            this.CenterToScreen();
            this.Location = new Point(this.Location.X, 0);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        protected override void OnShown(EventArgs i_EventArgs)
        {
            Thread currentThread = new Thread(() =>
            {
                m_CurrentEvents = m_LoggedInUser.EventsCreated;
                fetchEvents();
            });

            currentThread.Start();
        }

        private void updateInfo()
        {
            Action[] methods = new Action[]
            {
                setTimeAndDate,
                setCoverPicture,
                () => setControlText(UserNameLabel, m_LoggedInUser.Name),
                () => setPictureOnForm(UserProfilePictureBox, m_LoggedInUser.PictureNormalURL),
                () => setControlText(UserBirthdayLabel, getBirthdayDate()),
                () => setControlText(UserEmailLabel, getEmail()),
                () => setControlText(UserLivesInLabel, getLocationName()),
                () => setControlText(UserGenderLabel, getUserGender()),
                () => setControlText(UserInterestedInLabel, getUserInterstedIn()),
                () => setControlText(HoroscopeBirthdayLabel, "Birthday: " + getBirthdayDate())
            };

            try
            {
                Parallel.Invoke(methods);
            }
            catch(Exception)
            {
            }

            if (m_LoggedInUser.Birthday != null)
            {
                updateHoroscopeTabInfo(m_LoggedInUser.Birthday);
            }
            else
            {
                fetchUserBirthday();
            }
        }

        private void setCoverPicture()
        {
            if (m_LoggedInUser.Cover.SourceURL != null)
            {
                setPictureOnForm(CoverPictureBox, m_LoggedInUser.Cover.SourceURL);
            }
            else
            {
                CoverPictureBox.BackColor = Color.Turquoise; // default color
            }
        }

        private void setPictureOnForm(PictureBox i_PictureToSet, string i_PhotoUrl)
        {
            if (i_PictureToSet.InvokeRequired)
            {
                Invoke((MethodInvoker)(() => i_PictureToSet.LoadAsync(i_PhotoUrl)));
            }
            else
            {
                i_PictureToSet.LoadAsync(i_PhotoUrl);
            }
        }

        private string getUserInterstedIn()
        {
            string interstedIn = null;

            try
            {
                interstedIn = m_LoggedInUser.InterestedIn[0].ToString();
            }
            catch(Exception)
            {
            }

            return interstedIn;
        }

        private string getUserGender()
        {
            string gender = null;

            try
            {
                gender = m_LoggedInUser.Gender.ToString();
            }
            catch (Exception)
            {
            }

            return gender;
        }

        private void setControlText(Control i_ControlToSet, string i_Text)
        {
            if (i_ControlToSet.InvokeRequired)
            {
                Invoke((MethodInvoker)(() => i_ControlToSet.Text = i_Text));
            }
            else
            {
                i_ControlToSet.Text = i_Text;
            }
        }

        private void setTimeAndDate()
        {
            setControlText(TimeUILabel, DateTime.Now.ToLongTimeString());
            setControlText(DateUiLabel, DateTime.Now.ToLongDateString());
        }

        private void updateHoroscopeTabInfo(string i_Birthday)
        {
            m_UserZodiacSign = ZodiacSignFactory.GetZodiacSignByDate(i_Birthday);
            setControlText(ZodiacSignLabel, "Zodiac Sign: " + m_UserZodiacSign.SignName);

            if (SignPictureBox.InvokeRequired)
            {
                Invoke((MethodInvoker)(() => SignPictureBox.Image = Image.FromFile(m_UserZodiacSign.SignPhotoUrl)));
            }
            else
            {
                SignPictureBox.Image = Image.FromFile(m_UserZodiacSign.SignPhotoUrl);
            }
        }

        private void fetchUserBirthday()
        {
            this.Hide();
            
            if (r_SetBirthdayForm.ShowDialog() == DialogResult.OK)
            {
                updateHoroscopeTabInfo(r_SetBirthdayForm.UserBirthday);
                this.Show();
            }
        }

        private string getLocationName()
        {
            string location = null;

            try
            {
                location = m_LoggedInUser.Location.Name;
            }
            catch (NullReferenceException)
            {
            }

            return location;
        }

        private string getEmail()
        {
            string email = null;

            try
            {
                email = m_LoggedInUser.Email;
            }
            catch(NullReferenceException)
            {
            }

            return email;
        }

        private string getBirthdayDate()
        {
            string userBirthdayStr = null;

            try
            {
                string[] splitBirthday = m_LoggedInUser.Birthday.Split(new char[] { '/' });

                StringBuilder userBirthday = new StringBuilder();
                userBirthday.Append(splitBirthday[1] + "/"); // day
                userBirthday.Append(splitBirthday[0] + "/"); // month
                userBirthday.Append(splitBirthday[2]); // year
                userBirthdayStr = userBirthday.ToString();
            }
            catch(NullReferenceException)
            {
            }
            
            return userBirthdayStr;
        }

        private void friendsFirstNameOrderCheckBox_CheckedChanged(object i_Sender, EventArgs i_EventArgs)
        {
            if (FriendsFirstNameOrderCheckBox.Checked)
            {
                FriendsLastNameOrderCheckBox.Checked = false;
                m_CurrentChoice = eFrinedsListChoice.FirstNameOrder;
            }
            else
            {
                if (!FriendsLastNameOrderCheckBox.Checked)
                {
                    m_CurrentChoice = eFrinedsListChoice.RegularOrder;
                }
            }
        }

        private void friendsLastNameOrderCheckBox_CheckedChanged(object i_Sender, EventArgs i_EventArgs)
        {
            if (FriendsLastNameOrderCheckBox.Checked)
            {
                FriendsFirstNameOrderCheckBox.Checked = false;
                m_CurrentChoice = eFrinedsListChoice.LastNameOrder;
            }
            else
            {
                if (!FriendsFirstNameOrderCheckBox.Checked)
                {
                    m_CurrentChoice = eFrinedsListChoice.RegularOrder;
                }
            }
        }
        
        private void attendingRadioButton_Click(object i_Sender, EventArgs i_EventArgs)
        {
            runNewThreadOnEvents(eEventsType.Attending);
        }

        private void notAttendingRadioButton_Click(object i_Sender, EventArgs i_EventArgs)
        {
            runNewThreadOnEvents(eEventsType.NotAttending);
        }

        private void maybeRadioButton_Click(object i_Sender, EventArgs i_EventArgs)
        {
            runNewThreadOnEvents(eEventsType.Maybe);
        }

        private void notRepliedRadioButton_Click(object i_Sender, EventArgs i_EventArgs)
        {
            runNewThreadOnEvents(eEventsType.NotRepliad);
        }

        private void runNewThreadOnEvents(eEventsType i_EventsType)
        {
            Thread currentThread = new Thread(() =>
            {
                getCurrentEvents(out m_CurrentEvents, i_EventsType);
                fetchEvents();
            });

            currentThread.Start();
        }

        private void getCurrentEvents(out FacebookObjectCollection<Event> o_Events, eEventsType i_EventsType)
        {
            o_Events = null;

            switch(i_EventsType)
            {
                case eEventsType.Attending:
                    {
                        o_Events = m_LoggedInUser.EventsCreated;
                        break;
                    }

                case eEventsType.Maybe:
                    {
                        o_Events = m_LoggedInUser.EventsMaybe;
                        break;
                    }

                case eEventsType.NotAttending:
                    {
                        o_Events = m_LoggedInUser.EventsDeclined;
                        break;
                    }

                case eEventsType.NotRepliad:
                    {
                        o_Events = m_LoggedInUser.EventsNotYetReplied;
                        break;
                    }
            }
        }

        private void fetchEvents()
        {
            if (checkIfUserLoggedIn())
            {
                if (m_CurrentEvents.Count == 0)
                {
                    MessageBox.Show("There isn't events to show.", "Not registered to events");
                }
                else
                {
                    if (!EventsListBox.InvokeRequired)
                    {
                        EventBindingSource.DataSource = m_CurrentEvents;
                    }
                    else
                    {
                        EventsListBox.Invoke(new Action(() => EventBindingSource.DataSource = m_CurrentEvents));
                    }
                }
            }
        }

        private void fetchFriendButton_Click(object i_Sender, EventArgs i_EventArgs)
        {
            new Thread(fetchFriendList).Start();
        }

        private bool checkIfUserLoggedIn()
        {
            bool logged = false;

            if (m_LoggedInUser != null)
            {
                logged = true;
            }
            else
            {
                MessageBox.Show("Your not logged in", "Error");
            }

            return logged;
        }

        private void fetchFriendList()
        {
            if (checkIfUserLoggedIn())
            {
                List<User> userFriends = r_FriendsFacade.GetUserFrinedsByOrderChoice((int)m_CurrentChoice, m_LoggedInUser);

                if (userFriends != null)
                {
                    if (!FriendsListBox.InvokeRequired)
                    {
                        showFrinedsOnListBox(userFriends);
                    }
                    else
                    {
                        FriendsListBox.Invoke(new Action(() => showFrinedsOnListBox(userFriends)));
                    }
                }
                else
                {
                    MessageBox.Show("There isn't friends to show.");
                }
            }
        }
        
        private void showFrinedsOnListBox(List<User> i_UserFriends)
        {
            FriendsListBox.Items.Clear();
            FriendsListBox.DisplayMember = "Name";
            foreach (User friend in i_UserFriends)
            {
                FriendsListBox.Items.Add(friend);
                friend.ReFetch(DynamicWrapper.eLoadOptions.Full);
            }
        }

        private void fetchPostsButton_Click(object i_Sender, EventArgs i_EventArgs)
        {
            new Thread(fetchPosts).Start();
        }

        private void fetchPosts()
        {
            if(!m_PostFetch)
            {
                if (checkIfUserLoggedIn())
                {
                    if (m_LoggedInUser.Posts.Count == 0)
                    {
                        MessageBox.Show("No Posts to show");
                    }
                    else
                    {
                        if (!PostsListBox.InvokeRequired)
                        {
                            showPostsOnListBox();
                        }
                        else
                        {
                            PostsListBox.Invoke(new Action(() => showPostsOnListBox()));
                        }

                        m_PostFetch = true;
                    }
                }
            }
        }

        private void showPostsOnListBox()
        {
            foreach (Post post in m_LoggedInUser.Posts)
            {
                PostWrapper postWrapper = new PostWrapper(post);

                PostsListBox.Items.Add(postWrapper);
            }
        }

        private void postStatusButton_Click(object i_Sender, EventArgs i_EventArgs)
        {
            if (checkIfUserLoggedIn())
            {
                if (!string.IsNullOrEmpty(StatusTextBox.Text))
                {
                    Status postedStatus = m_LoggedInUser.PostStatus(StatusTextBox.Text);

                    StatusTextBox.Clear();
                    MessageBox.Show("Status Posted! " + postedStatus.Id);
                }
                else
                {
                    MessageBox.Show("Please write something in the textbox");
                }
            }
        }

        private void fetchLikedPagesButton_Click(object i_Sender, EventArgs i_EventArgs)
        {
            new Thread(fetchLikedPages).Start();
        }

        private void fetchLikedPages()
        {
            if (checkIfUserLoggedIn())
            {
                List<Page> pages = fetchLikedPagesByOrderChoice();

                if (pages.Capacity == 0)
                {
                    MessageBox.Show("No liked pages to show");
                }
                else
                {
                    if (!LikedPagesListBox.InvokeRequired)
                    {
                        showLikedPagesListOnListBox(pages);
                    }
                    else
                    {
                        LikedPagesListBox.Invoke(new Action(() => showLikedPagesListOnListBox(pages)));
                    }
                }
            }
        }

        private List<Page> fetchLikedPagesByOrderChoice()
        {
            List<Page> pages = null;

            if (!LikedPagesInOrderCheckBox.Checked)
            {
                pages = SortingAndCopyService.CopyPagesToList(m_LoggedInUser.LikedPages);
            }
            else
            {
                pages = SortingAndCopyService.SortPages(m_LoggedInUser.LikedPages);
            }

            return pages;
        }

        private void showLikedPagesListOnListBox(List<Page> i_UserLikedPages)
        {
            LikedPagesListBox.Items.Clear();
            LikedPagesListBox.DisplayMember = "Name";
            foreach (Page page in i_UserLikedPages)
            {
                LikedPagesListBox.Items.Add(page);
            }
        }
        
        private void likedPagesListBox_SelectedIndexChanged(object i_Sender, EventArgs i_EventArgs)
        {
            displaySelectedPagePicture();
        }
        
        private void displaySelectedPagePicture()
        {
            if (LikedPagesListBox.SelectedItems.Count == 1)
            {
                Page selectedPage = LikedPagesListBox.SelectedItem as Page;

                if (selectedPage.PictureNormalURL != null)
                {
                    LikedPagePictureBox.LoadAsync(selectedPage.PictureNormalURL);
                }
            }
        }
        
        private void friendsListBox_SelectedIndexChanged(object i_Sender, EventArgs i_EventArgs)
        {
            displaySelectedFriendPicture(FriendsListBox, FriendCheckedPictureBox);
        }

        private void displaySelectedFriendPicture(Control i_SelectedListBox, Control i_SelectedPictureBox)
        {
            ListBox selectedListBox = i_SelectedListBox as ListBox;
            PictureBox selectedPictureBox = i_SelectedPictureBox as PictureBox;

            if (selectedListBox.SelectedItems.Count == 1)
            {
                User selectedFriend = selectedListBox.SelectedItem as User;

                if (selectedFriend.PictureNormalURL != null)
                {
                    selectedPictureBox.LoadAsync(selectedFriend.PictureNormalURL);
                }
            }
        }

        private void fetchAlbumsButton_Click(object i_Sender, EventArgs i_EventArgs)
        {
            new Thread(fetchAlbums).Start();
        }

        private void fetchAlbums()
        {
            if (checkIfUserLoggedIn())
            {
                List<Album> albums = getAlbumsList();

                if (albums.Count == 0)
                {
                    MessageBox.Show("No albums to show");
                }
                else
                {
                    if (!AlbumsListBox.InvokeRequired)
                    {
                        AlbumBindingSource.DataSource = albums;
                    }
                    else
                    {
                        AlbumsListBox.Invoke(new Action(() => AlbumBindingSource.DataSource = albums));
                    }
                }
            }
        }

        private List<Album> getAlbumsList()
        {
            List<Album> albums = null;

            if (!AlbumsOrderCheckBox.Checked)
            {
                albums = SortingAndCopyService.CopyAlbumsToList(m_LoggedInUser.Albums);
            }
            else
            {
                albums = SortingAndCopyService.SortAlbums(m_LoggedInUser.Albums);
            }

            return albums;
        }
        
        private void fetchSingelsFriendsButton_Click(object i_Sender, EventArgs i_EventArgs)
        {
           fetchSingelsFriends();
        }

        private void fetchSingelsFriends()
        {
            if (checkIfUserLoggedIn())
            {
                if (GenderComboBox.Text != string.Empty)
                {
                    if (!(m_LoggedInUser.Friends.Count == 0))
                    {
                        List<User> singelsFriends = getSingelsFriends(m_LoggedInUser.Friends, GenderComboBox.Text);

                        showSingelsFriendOnListBox(singelsFriends);
                    }
                    else
                    {
                        MessageBox.Show("There isn't friends in your friends list.");
                    }
                }
                else
                {
                    MessageBox.Show(
@"You didn't choose your desired gender,
Please try again.",
                  "Error");
                }
            }
        }

        private List<User> getSingelsFriends(FacebookObjectCollection<User> i_UserFriends, string i_UserDesiredGender)
        {
            List<User> singelsFriends = new List<User>();

            foreach (User friend in i_UserFriends)
            {
                if (friend.Gender.ToString() == i_UserDesiredGender && friend.RelationshipStatus == User.eRelationshipStatus.Single)
                {
                    singelsFriends.Add(friend);
                }
            }

            return singelsFriends;
        }

        private void showSingelsFriendOnListBox(List<User> i_SingelsFriends)
        {
            if (i_SingelsFriends.Count != 0)
            {
                foreach (User friend in m_LoggedInUser.Friends)
                {
                    SingelsFriendsListBox.Items.Add(friend.Name);
                }
            }
            else
            {
                MessageBox.Show("There isn't singels friends in that gender.");
            }
        }

        private void logoutButton_Click(object i_Sender, EventArgs i_EventArgs)
        {
            FacebookService.Logout(onLogOut);
        }

        private void onLogOut()
        {
            this.Hide();

            if(r_LoginForm.ShowDialog() == DialogResult.OK)
            {
                m_LoggedInUser = r_LoginForm.LoginResult.LoggedInUser;
                new Thread(updateInfo).Start();
                this.Show();
            }
        }

        private void fetchHoroscopeButton_Click(object i_Sender, EventArgs i_EventArgs)
        {
            new Thread(fetchDailyHoroscope).Start();
        }

        private void fetchDailyHoroscope()
        {
            if (m_UserZodiacSign != null)
            {
                string horoscope = m_UserZodiacSign.SetWebUrlBySignAndGetDailyHoroscope();
                setControlText(HoroscopeTextBox, horoscope);
            }
        }

        private void createAlbumButton_Click(object i_Sender, EventArgs i_EventArgs)
        {
            r_CreateNewAlbumForm.CurrentUser = m_LoggedInUser;
            this.Hide();

            if (r_CreateNewAlbumForm.ShowDialog() == DialogResult.OK)
            {
                this.Show();
            }
        }

        private void showCheckInsButton_Click(object i_Sender, EventArgs i_EventArgs)
        {
            this.Hide();
            r_CheckInsOnMapForm.UserCheckIns = m_LoggedInUser.Checkins;

            if (r_CheckInsOnMapForm.ShowDialog() == DialogResult.OK)
            {
                this.Show();
            }
        }

        private void getPlaylistButton_Click(object i_Sender, EventArgs i_EventArgs)
        {
            this.Hide();
            r_PlaylistForm.UserLinks = m_LoggedInUser.PostedLinks;
            r_PlaylistForm.m_LoggedInUser = m_LoggedInUser;

            if (r_PlaylistForm.ShowDialog() == DialogResult.OK)
            {
                this.Show();
            }
        }

        private void mainForm_FormClosed(object i_Sender, FormClosedEventArgs i_EventArgs)
        {
            Application.Exit();
        }

        private void singelsFriendsListBox_SelectedIndexChanged(object i_Sender, EventArgs i_EventArgs)
        {
            displaySelectedFriendPicture(SingelsFriendsListBox, GetInThouchPictureBox);
        }
        
        private void selectsPartnerButton_Click(object i_Sender, EventArgs i_EventArgs)
        {
            this.Hide();

            if (r_PartnerSignForm.ShowDialog() == DialogResult.OK)
            {
                m_UserPartnerSign = r_PartnerSignForm.PartnerSign;
                this.Show();
                if (m_UserPartnerSign != null)
                {
                    new Thread(showDescriptionOnMatch).Start();
                }
                else
                {
                    MessageBox.Show(
@"You didn't choose your partner sign,
Please try again.",
                  "Error");
                }
            }
        }

        private void showDescriptionOnMatch()
        {
            string horoscope = m_UserZodiacSign.SetWebUrlBySignAndGetDescriptionOnMatch(m_UserPartnerSign);
            setControlText(HoroscopeTextBox, horoscope);
        }

        private void getMathcesButton_Click(object i_Sender, EventArgs i_EventArgs)
        {
            List<string> userMatches = m_UserZodiacSign.MatchPartners;
            StringBuilder textToShow = new StringBuilder();

            textToShow.AppendLine("Your matches zodiac signs are:");
            foreach(string sign in userMatches)
            {
                textToShow.AppendLine(sign);
            }

            HoroscopeTextBox.Text = textToShow.ToString();
        }

        private void timer_Tick(object i_Sender, EventArgs i_EventArgs)
        {
            TimeUILabel.Text = DateTime.Now.ToLongTimeString();
            Timer.Start();
        }
    }
}