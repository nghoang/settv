using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace settv
{
    public interface IServerRequest
    {
        void FinishedLoadCategory(List<Category> list);
        void FinishedLoadCountry(List<Country> list);
        void FinishedLoadChannel(List<Channel> list);
        void FinishedSearchingYoutube(List<YoutubeObject> list);
    }
}
