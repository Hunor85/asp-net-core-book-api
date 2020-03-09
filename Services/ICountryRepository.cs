﻿using System;
using System.Collections.Generic;
using asp_net_core_book_api.Models;

namespace asp_net_core_book_api.Services
{
    public interface ICountryRepository
    {
        ICollection<Country> GetCountries();
        Country GetCountry(int countryId);
        Country GetCountryOfAnAuthor(int authorId);
        ICollection<Author> GetAuthorsFromACountry(int countryId);
        bool CountryExists(int countryId);
    }
}
