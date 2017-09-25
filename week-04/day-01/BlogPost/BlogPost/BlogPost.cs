using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogPost
{
    class BlogPost
    {
        string AuthorName;
        string Title;
        string Text;
        string PublicationsDate;

        public void SetAuthorName(string newName)
        {
            AuthorName = newName;
        }

        public string GetAuthorName()
        {
            return AuthorName;
        }

        public void SetTitle (string newTitle)
        {
            Title = newTitle;
        }

        public string GetTitle()
        {
            return Title;
        }

        public void SetText (string newText)
        {
            Text = newText;
        }

        public string GetText()
        {
            return Text;
        }

        public void SetPublicationsDate(string newDate)
        {
            PublicationsDate = newDate;
        }

        public string GetPublciationsDate()
        {
            return PublicationsDate;
        }
    }
}
