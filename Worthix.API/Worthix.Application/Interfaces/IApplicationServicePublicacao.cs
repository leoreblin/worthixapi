using System;
using System.Collections.Generic;
using System.Text;
using Worthix.API.Application.DTOs;

namespace Worthix.API.Application.Interfaces
{
    public interface IApplicationServicePublicacao
    {
        void Add(PublicacaoDTO autorDTO);
    }
}
