using System;

namespace Carubbi.DAL
{
    /// <summary>
    ///     Atributo utilizado para marcar Propriedades que não devem ser mapeadas pelo framework de persistência Carubbi.DAL
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
    public sealed class CampoNaoPersistivelAttribute : Attribute
    {
    }
}