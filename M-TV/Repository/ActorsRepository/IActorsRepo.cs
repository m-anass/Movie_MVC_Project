﻿namespace M_TV.Repository.ActorsRepository
{
    public interface IActorsRepo
    {
        public IEnumerable<SelectListItem> GetSelectListsActors();
    }
}
