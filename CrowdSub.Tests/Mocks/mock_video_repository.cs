﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrowdSub.Repositories;
using CrowdSub.Models;

namespace CrowdSub.Tests.Mocks
{
    public class mock_video_repository : i_video_repository
    {

        public bool create_video(video new_video)
        {
            throw new NotImplementedException();
        }

        public bool edit_video(int id)
        {
            throw new NotImplementedException();
        }

        public bool remove_video(int id)
        {
            throw new NotImplementedException();
        }

        public video get_video(int id)
        {
            throw new NotImplementedException();
        }

        public List<video> get_all_videos()
        {
            throw new NotImplementedException();
        }

        public bool search_for_video(int id)
        {
            throw new NotImplementedException();
        }
    }
}