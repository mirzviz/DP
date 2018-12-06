using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacebookAppLogic
{
    public abstract class URLSong
    {
        protected string m_VideoURL;
        protected string m_AudioURL;

        public URLSong(string i_VideoURL, string i_AudioURL)
        {
            m_VideoURL = i_VideoURL;
            m_AudioURL = i_AudioURL;
            if (!IsValidURL(m_VideoURL) && !IsValidURL(m_AudioURL))
            {
                throw new Exception("this URL doesnt match!");
            }
        }

        public abstract bool IsValidURL(string i_URL);

        public string VideoURL
        {
            get
            {
                return m_VideoURL;
            }
        }

        public string AudioURL
        {
            get
            {
                return m_AudioURL;
            }
        }
    }
}
