﻿using DogeNews.Web.Models;

namespace DogeNews.Web.Services.Contracts
{
    public interface IArticleManagementService
    {
        void Add(string username, NewsWebModel newsItem);

        void Update(NewsWebModel model);

        void Delete(int id);

        void Restore(int id);
    }
}