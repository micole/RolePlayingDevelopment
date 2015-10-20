
using System;

namespace RolePlayingCharacterDevelopment
{
    public enum Profession
    {
        //Artisan
        Blacksmith,
        Jeweler,
        Cook,
        Sculptor,
        Carpenter,
        Potter,
        Calligrapher,
        //Artist
        Painter,
        Actor,
        StoryTeller,
        Author,
        //Beaureaucrat
        Clerk,
        Diplomat,
        Spy,
        Lobbyist,
        Academic,
        Lawyer,
        //Criminal
        Thug,
        Thief,
        GangMember,
        Swindler,
        Assassin,
        Scavenger,
        //Explorer
        TreasureHunter,
        Traveler,
        Guide,
        Diver,
        Prospector,
        MapMaker,
        Sailor,
        Scout,
        //Laborer
        Farmer,
        Fisherman,
        WoodCutter,
        Shepherd,
        Servant,
        Messenger,
        Hunter,
        Rancher,
        //Merchant
        TravelingMerchant,
        GuildMember,
        Transporter,
        InnKeeper,
        //Noble
        Noble,
        //Outsider
        Hermit,
        Outlander,
        //Priest
        TempleLord,
        Healer,
        Chosen,
        //Scholar
        Instructor,
        Writer,
        Researcher,
        Student,
        //Warrior
        Soldier,
        Gladiator,
        Knight,
        BountyHunter,
        Mercenary,
        Guard,
        Squire

    }

    public static class Professions
    {
        public static Profession RandomArtisanProfession()
        {
            Profession[] artisan = { Profession.Blacksmith, Profession.Jeweler, Profession.Cook, Profession.Sculptor, Profession.Carpenter, Profession.Potter, Profession.Calligrapher };
            Random random = new Random();
            return artisan[random.Next(artisan.Length)];
        }
    }
}
