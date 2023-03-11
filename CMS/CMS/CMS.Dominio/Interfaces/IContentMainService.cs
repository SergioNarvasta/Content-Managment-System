﻿using CMS.Dominio.Entidades;

namespace CMS.Dominio.Interfaces
{
    public interface IContentMainService
    {
        Task DeleteContentMain(string id);
        Task<IEnumerable<ContentMain>> GetAllContentMain();
        Task InsertContentMain(ContentMain contentmain);
        Task UpdateContentMain(ContentMain contentmain);
    }
}
