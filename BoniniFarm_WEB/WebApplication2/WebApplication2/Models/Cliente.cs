using System;
using Microsoft.Data.SqlClient;  // Use o namespace do pacote Microsoft.Data.SqlClient

public class Cliente
{
    public int matricula { get; set; }
    public int nome { get; set; }
    public int cnpj { get; set; }
    public int cpf { get; set; }
    public int login { get; set; }
    public int senha { get; set; }
}