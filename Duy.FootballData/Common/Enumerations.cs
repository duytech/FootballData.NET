namespace Duy.FootballData.Common
{
    public enum ResponseControl
    {
        Full,
        Minified,
        Compressed
    }

    public enum Venue
    {
        Home,
        Away
    }

    public enum TimeDirection
    {
        Next,
        Past
    }

    public enum LeagueCode
    {
        /// <summary>
        /// Germany 1. Bundesliga
        /// </summary>
        BL1,
        /// <summary>
        /// Germany 2. Bundesliga
        /// </summary>
        BL2,
        /// <summary>
        /// Germany 3. Bundesliga
        /// </summary>
        BL3,
        /// <summary>
        /// Germany Dfb-Cup
        /// </summary>
        DFB,
        /// <summary>
        /// England Premiere League
        /// </summary>
        PL,
        /// <summary>
        /// England League One
        /// </summary>
        EL1,
        /// <summary>
        /// England Championship
        /// </summary>
        ELC,
        /// <summary>
        /// England FA-Cup
        /// </summary>
        FAC,
        /// <summary>
        /// Italy Serie A
        /// </summary>
        SA,
        /// <summary>
        /// Italy Serie B
        /// </summary>
        SB,
        /// <summary>
        /// Spain Primera Division
        /// </summary>
        PD,
        /// <summary>
        /// Spain Segunda Division
        /// </summary>
        SD,
        /// <summary>
        /// Spain Copa del Rey
        /// </summary>
        CDR,
        /// <summary>
        /// France Ligue 1
        /// </summary>
        FL1,
        /// <summary>
        /// France Ligue 2
        /// </summary>
        FL2,
        /// <summary>
        /// Netherlands Eredivisie
        /// </summary>
        DED,
        /// <summary>
        /// Portugal Primeira Liga
        /// </summary>
        PPL,
        /// <summary>
        /// Greece Super League
        /// </summary>
        GSL,
        /// <summary>
        /// Europe Champions-League
        /// </summary>
        CL,
        /// <summary>
        /// Europe UEFA-Cup
        /// </summary>
        EL,
        /// <summary>
        /// Europe European-Cup of Nations
        /// </summary>
        EC,
        /// <summary>
        /// World World-Cup
        /// </summary>
        WC
    }
}
