using System;
using System.Collections.Generic;

namespace CSPHARMA_DAL.Modelos;

public partial class User
{
    public long Id { get; set; }

    public string UsuarioNick { get; set; } = null!;

    public string UsuarioPassword { get; set; } = null!;
}
