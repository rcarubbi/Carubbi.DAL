namespace Carubbi.DAL
{
    /// <summary>
    ///     Classe responsável por definir convenções de nomes dos objetos de banco de dados
    ///     <example>
    ///         <list type="bullet">
    ///             <item>Prefixo de nome de procedures</item>
    ///             <item>nome de schema</item>
    ///             <item>Prefixo nas colunas de resultados de procedures</item>
    ///             <item>Prefixo nos parâmetros de entrada de procedures</item>
    ///             <item>Chave da ConnectionString no arquivo de configurações</item>
    ///         </list>
    ///     </example>
    /// </summary>
    public static class DataBaseConventions
    {
        /// <summary>
        ///     Getter e Setter do método de definição da regra para gerar o nome das tabelas a partir dos nomes das entidades
        /// </summary>
        public static EntityNameConventionHandler EntityNameConventionHandler { get; set; }

        public static string ConnectionStringKey { get; set; } = "Conexao";

        public static string StoredProcedurePrefix { get; set; } = "SP_";

        public static string SchemaName { get; set; } = "dbo";

        public static string OutputFieldnamePrefix { get; set; }

        public static string InputParametersPrefix { get; set; }
    }
}