﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Titan.Model;

namespace Titan.Service.Datum
{
    public interface IDatumService: IReadOnlyDatumService
    {
        Task<DatumModel> AddAsync();
        Task<DatumModel> UpdateAsync();
        Task<bool> DeleteAsync();
    }
}