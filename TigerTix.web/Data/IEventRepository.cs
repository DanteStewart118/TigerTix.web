﻿using System.Collections.Generic;
using TigerTix.web.Data.Entities;

namespace TigerTix.web.Data
{
    public interface IEventRepository
    {
        void DeleteEvent(Event ev);
        IEnumerable<Event> GetAllEvents();
        void SaveEvent(Event ev);
        void UpdateEvent(Event ev);
        bool SaveAll();
    }
}