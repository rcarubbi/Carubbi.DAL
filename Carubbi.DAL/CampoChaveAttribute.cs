using System;

namespace Carubbi.DAL
{
    /// <summary>
    ///     Atributo para marcar propriedades como Campos Chave, utilizada junto com o framework de persistencia Carubbi.DAL
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
    public sealed class CampoChaveAttribute : Attribute
    {
    }
}