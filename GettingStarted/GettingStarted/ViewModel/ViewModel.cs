using System;
using System.Collections.ObjectModel;
using Syncfusion.XForms.Chat;
using System.ComponentModel;
using Xamarin.Forms;
using System.Collections.Generic;

namespace GettingStarted
{
    public class ViewModel : INotifyPropertyChanged
    {
        /// <summary>
        /// Collection of messages in a conversation.
        /// </summary>
        private ObservableCollection<object> messages;

        /// <summary>
        /// Current user of chat.
        /// </summary>
        private Author currentAuthor;

        private Author Harrison = new Author() { Name = "Harrison", Avatar = "Harrison.png" };

        private Author Margaret = new Author() { Name = "Margaret", Avatar = "Margaret.png" };

        private int colorIndex = 0;

        private Color[] Colors = new Color[]
        {
            Color.Yellow,
            Color.Red,
            Color.Blue,
            Color.Green,
            Color.Violet,
            Color.Pink,
            Color.White,
        };

        public ViewModel()
        {
            this.messages = new ObservableCollection<object>();
            this.AuthorColors = new Dictionary<Author, Color>();
            this.currentAuthor = new Author() { Name = "Nancy", Avatar = "Nancy.png" };
            this.GenerateMessages();
        }

        public Color AddColorForAuthor(Author author)
        {
            this.AuthorColors.Add(author, this.Colors[colorIndex]);
            colorIndex++;
            return this.Colors[colorIndex];
        }

        public Dictionary<Author, Xamarin.Forms.Color> AuthorColors;

        /// <summary>
        /// Gets or sets the collection of messages of a conversation.
        /// </summary>
        public ObservableCollection<object> Messages
        {
            get
            {
                return this.messages;
            }

            set
            {
                this.messages = value;
            }
        }

        /// <summary>
        /// Gets or sets the current user of the message.
        /// </summary>
        public Author CurrentUser
        {
            get
            {
                return this.currentAuthor;
            }
            set
            {
                this.currentAuthor = value;
                RaisePropertyChanged("CurrentUser");
            }
        }

        /// <summary>
        /// Property changed handler.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Occurs when property is changed.
        /// </summary>
        /// <param name="propName">changed property name</param>
        public void RaisePropertyChanged(string propName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }

        private void GenerateMessages()
        {
            this.messages.Add(new TextMessage()
            {
                Author = currentAuthor,
                Text = "Hi guys, good morning! I'm very delighted to share with you the news that our team is going to launch a new mobile application.",
                DateTime = DateTime.Now
            });

            this.messages.Add(new TextMessage()
            {
                Author = this.Harrison,
                Text = "That is good news.",
                DateTime = DateTime.Now
            });

            this.messages.Add(new TextMessage()
            {

                Author = this.Margaret,
                Text = "What kind of application is it and when are we going to launch?",
                DateTime = DateTime.Now
            });

            this.messages.Add(new TextMessage()
            {
                Author = currentAuthor,
                Text = "A kind of Emergency Broadcast App.",
                DateTime = DateTime.Now
            });

            this.messages.Add(new TextMessage()
            {
                Author = this.Harrison,
                Text = "That is good news.",
                DateTime = DateTime.Now
            });

            this.messages.Add(new TextMessage()
            {
                Author = this.Margaret,
                Text = "What kind of application is it and when are we going to launch?",
                DateTime = DateTime.Now
            });

            this.messages.Add(new TextMessage()
            {
                Author = currentAuthor,
                Text = "A kind of Emergency Broadcast App.",
                DateTime = DateTime.Now
            });

            this.messages.Add(new TextMessage()
            {
                Author = this.Harrison,
                Text = "That is good news.",
                DateTime = DateTime.Now
            });

            this.messages.Add(new TextMessage()
            {
                Author = this.Margaret,
                Text = "What kind of application is it and when are we going to launch?",
                DateTime = DateTime.Now
            });

            this.messages.Add(new TextMessage()
            {
                Author = currentAuthor,
                Text = "A kind of Emergency Broadcast App.",
                DateTime = DateTime.Now
            });
        }
    }
}
