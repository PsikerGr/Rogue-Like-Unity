﻿using System.Collections.Generic;
using UnityEngine;

public class NameGenerator {

    public static string GenerateNewName(int rarity, string base_name)
    {
        List<string> prefix_list = preparePrefixList();
        List<string> suffix_list = prepareSuffixList();

        string prefix = "";
        string suffix = "";

        if (rarity >= 5)
            prefix += prefix_list[Random.Range(0, prefix_list.Count - 1)] + " ";
        if (rarity >= 4)
            suffix += " " + suffix_list[Random.Range(0, suffix_list.Count - 1)] + " &";
        if (rarity >= 3)
            prefix += prefix_list[Random.Range(0, prefix_list.Count - 1)] + " ";
        if (rarity >= 2)
            suffix += " " + suffix_list[Random.Range(0, suffix_list.Count - 1)];

        return prefix + base_name + suffix;
    }

    private static List<string> preparePrefixList()
    {
        List<string> prefix_list = new List<string>();
        prefix_list.Add("Super");
        prefix_list.Add("Mega");
        prefix_list.Add("Supra");
        prefix_list.Add("Cool");
        prefix_list.Add("Elegant");
        prefix_list.Add("Classic");
        prefix_list.Add("Strong");
        prefix_list.Add("Weird");
        prefix_list.Add("Strange");
        prefix_list.Add("Visionary");
        prefix_list.Add("Massive");
        prefix_list.Add("Cruel");
        prefix_list.Add("Savage");
        prefix_list.Add("Master's");
        prefix_list.Add("Lunar");
        prefix_list.Add("Celestial");
        prefix_list.Add("Pure");
        prefix_list.Add("Divine");
        prefix_list.Add("Sacred");
        prefix_list.Add("Glorious");
        prefix_list.Add("Victorious");
        prefix_list.Add("Acclaimed");
        prefix_list.Add("Admired");
        prefix_list.Add("Almighty");
        prefix_list.Add("Anticipated");
        prefix_list.Add("Arching");
        prefix_list.Add("Assured");
        prefix_list.Add("Astonishing");
        prefix_list.Add("Avoiding");
        prefix_list.Add("Blocking");
        prefix_list.Add("Bold");
        prefix_list.Add("Brawling");
        prefix_list.Add("Brawny");
        prefix_list.Add("Brilliant");
        prefix_list.Add("Brute");
        prefix_list.Add("Burly");
        prefix_list.Add("Butchering");
        prefix_list.Add("Calloused");
        prefix_list.Add("Celebrated");
        prefix_list.Add("Clandestine");
        prefix_list.Add("Combating");
        prefix_list.Add("Conflicting");
        prefix_list.Add("Conserving");
        prefix_list.Add("Constant");
        prefix_list.Add("Cunning");
        prefix_list.Add("Curious");
        prefix_list.Add("Daring");
        prefix_list.Add("Darting");
        prefix_list.Add("Dashing");
        prefix_list.Add("Defensive");
        prefix_list.Add("Defiant");
        prefix_list.Add("Deflecting");
        prefix_list.Add("Demolishing");
        prefix_list.Add("Dense");
        prefix_list.Add("Devastating");
        prefix_list.Add("Dignified");
        prefix_list.Add("Distinct");
        prefix_list.Add("Distinguished");
        prefix_list.Add("Diverting");
        prefix_list.Add("Divine");
        prefix_list.Add("Driving");
        prefix_list.Add("Earthen");
        prefix_list.Add("Eccentric");
        prefix_list.Add("Elevated");
        prefix_list.Add("Elite");
        prefix_list.Add("Elusive");
        prefix_list.Add("Enforced");
        prefix_list.Add("Eradicating");
        prefix_list.Add("Essential");
        prefix_list.Add("Esteemed");
        prefix_list.Add("Exalted");
        prefix_list.Add("Exceptional");
        prefix_list.Add("Excessive");
        prefix_list.Add("Fabled");
        prefix_list.Add("Fantastic");
        prefix_list.Add("Fighting");
        prefix_list.Add("Firm");
        prefix_list.Add("Flourishing");
        prefix_list.Add("Foretold");
        prefix_list.Add("Forgotten");
        prefix_list.Add("Formidable");
        prefix_list.Add("Girded");
        prefix_list.Add("Gleaming");
        prefix_list.Add("Gliding");
        prefix_list.Add("Glimmering");
        prefix_list.Add("Goring");
        prefix_list.Add("Grounded");
        prefix_list.Add("Hallowed");
        prefix_list.Add("Harsh");
        prefix_list.Add("Hefty");
        prefix_list.Add("Hulking");
        prefix_list.Add("Husky");
        prefix_list.Add("Illustrious");
        prefix_list.Add("Immaculate");
        prefix_list.Add("Immense");
        prefix_list.Add("Impeding");
        prefix_list.Add("Impressive");
        prefix_list.Add("Incomparable");
        prefix_list.Add("Incredible");
        prefix_list.Add("Informal");
        prefix_list.Add("Infused");
        prefix_list.Add("Inspired");
        prefix_list.Add("Intact");
        prefix_list.Add("Intense");
        prefix_list.Add("Launching");
        prefix_list.Add("Legendary");
        prefix_list.Add("Loyal");
        prefix_list.Add("Lurid");
        prefix_list.Add("Majestic");
        prefix_list.Add("Marvelous");
        prefix_list.Add("Merciless");
        prefix_list.Add("Meticulous");
        prefix_list.Add("Miraculous");
        prefix_list.Add("Momentous");
        prefix_list.Add("Mystic");
        prefix_list.Add("Negating");
        prefix_list.Add("Neutralizing");
        prefix_list.Add("Noble");
        prefix_list.Add("Notable");
        prefix_list.Add("Notorious");
        prefix_list.Add("Novel");
        prefix_list.Add("Obedient");
        prefix_list.Add("Obscure");
        prefix_list.Add("Obstructing");
        prefix_list.Add("Optimistic");
        prefix_list.Add("Organic");
        prefix_list.Add("Outlandish");
        prefix_list.Add("Outrageous");
        prefix_list.Add("Palpable");
        prefix_list.Add("Peerless");
        prefix_list.Add("Persevering");
        prefix_list.Add("Praised");
        prefix_list.Add("Predestined");
        prefix_list.Add("Preeminent");
        prefix_list.Add("Prevailing");
        prefix_list.Add("Pristine");
        prefix_list.Add("Prized");
        prefix_list.Add("Propelling");
        prefix_list.Add("Protective");
        prefix_list.Add("Pummeling");
        prefix_list.Add("Radiant");
        prefix_list.Add("Ravaging");
        prefix_list.Add("Recoiling");
        prefix_list.Add("Refined");
        prefix_list.Add("Relentless");
        prefix_list.Add("Reliant");
        prefix_list.Add("Remarkable");
        prefix_list.Add("Renowned");
        prefix_list.Add("Repellant");
        prefix_list.Add("Resilient");
        prefix_list.Add("Resistant");
        prefix_list.Add("Respected");
        prefix_list.Add("Retreating");
        prefix_list.Add("Revered");
        prefix_list.Add("Rough");
        prefix_list.Add("Rugged");
        prefix_list.Add("Rushing");
        prefix_list.Add("Ruthless");
        prefix_list.Add("Sabotaging");
        prefix_list.Add("Sacred");
        prefix_list.Add("Scuffling");
        prefix_list.Add("Secret");
        prefix_list.Add("Skirmishing");
        prefix_list.Add("Soaring");
        prefix_list.Add("Solemn");
        prefix_list.Add("Solid");
        prefix_list.Add("Spectacular");
        prefix_list.Add("Splendid");
        prefix_list.Add("Splendorous");
        prefix_list.Add("Stately");
        prefix_list.Add("Staunch");
        prefix_list.Add("Steadfast");
        prefix_list.Add("Stern");
        prefix_list.Add("Strategic");
        prefix_list.Add("Stringent");
        prefix_list.Add("Stupendous");
        prefix_list.Add("Sublime");
        prefix_list.Add("Superior");
        prefix_list.Add("Superlative");
        prefix_list.Add("Supreme");
        prefix_list.Add("Sustained");
        prefix_list.Add("Tactile");
        prefix_list.Add("Talismanic");
        prefix_list.Add("Tenacious");
        prefix_list.Add("Terranean");
        prefix_list.Add("Terrestrial");
        prefix_list.Add("Thwarting");
        prefix_list.Add("Treasured");
        prefix_list.Add("Trusted");
        prefix_list.Add("Uncommon");
        prefix_list.Add("Uncompromising");
        prefix_list.Add("Unequivocal");
        prefix_list.Add("Unfathomable");
        prefix_list.Add("Unparalleled");
        prefix_list.Add("Unsurpassed");
        prefix_list.Add("Unwavering");
        prefix_list.Add("Unwearied");
        prefix_list.Add("Unyielding");
        prefix_list.Add("Utmost");
        prefix_list.Add("Valued");
        prefix_list.Add("Vengeful");
        prefix_list.Add("Warring");
        prefix_list.Add("Wiley");

        return prefix_list;
    }

    private static List<string> prepareSuffixList()
    {
        List<string> suffix_list = new List<string>();
        suffix_list.Add("Made by Gods");
        suffix_list.Add("of Gold");
        suffix_list.Add("Cheated");
        suffix_list.Add("of Fire");
        suffix_list.Add("of Abundance");
        suffix_list.Add("of Acceleration");
        suffix_list.Add("of Accuracy");
        suffix_list.Add("of Adversaries");
        suffix_list.Add("of Afar");
        suffix_list.Add("of Affluence");
        suffix_list.Add("of Aggression");
        suffix_list.Add("of Agility");
        suffix_list.Add("of Agony");
        suffix_list.Add("of Ailment");
        suffix_list.Add("of Animation");
        suffix_list.Add("of Antagonism");
        suffix_list.Add("of Aptitude");
        suffix_list.Add("of Ash");
        suffix_list.Add("of Aspiration");
        suffix_list.Add("of Attainment");
        suffix_list.Add("of Awareness");
        suffix_list.Add("of Beyond");
        suffix_list.Add("of Blistering");
        suffix_list.Add("of Blizzards");
        suffix_list.Add("of Boundlessness");
        suffix_list.Add("of Bounty");
        suffix_list.Add("of Breadth");
        suffix_list.Add("of Briars");
        suffix_list.Add("of Burning");
        suffix_list.Add("of Calculation");
        suffix_list.Add("of Carnage");
        suffix_list.Add("of Carving");
        suffix_list.Add("of Cautery");
        suffix_list.Add("of Certainty");
        suffix_list.Add("of Chilling");
        suffix_list.Add("of Cinders");
        suffix_list.Add("of Clashing");
        suffix_list.Add("of Claws");
        suffix_list.Add("of Coals");
        suffix_list.Add("of Coldness");
        suffix_list.Add("of Colossus");
        suffix_list.Add("of Confidence");
        suffix_list.Add("of Consumption");
        suffix_list.Add("of Contempt");
        suffix_list.Add("of Contention");
        suffix_list.Add("of Conviction");
        suffix_list.Add("of Courage");
        suffix_list.Add("of Craft");
        suffix_list.Add("of Creation");
        suffix_list.Add("of Currents");
        suffix_list.Add("of Cyclones");
        suffix_list.Add("of Dawn");
        suffix_list.Add("of Daylight");
        suffix_list.Add("of Deception");
        suffix_list.Add("of Defiance");
        suffix_list.Add("of Design");
        suffix_list.Add("of Detail");
        suffix_list.Add("of Diligence");
        suffix_list.Add("of Discord");
        suffix_list.Add("of Disease");
        suffix_list.Add("of Disparity");
        suffix_list.Add("of Dispute");
        suffix_list.Add("of Dissension");
        suffix_list.Add("of Distance");
        suffix_list.Add("of Dread");
        suffix_list.Add("of Dusk");
        suffix_list.Add("of Embers");
        suffix_list.Add("of Emphasis");
        suffix_list.Add("of Endeavor");
        suffix_list.Add("of Endowment");
        suffix_list.Add("of Energy");
        suffix_list.Add("of Enhancement");
        suffix_list.Add("of Enormity");
        suffix_list.Add("of Epidemic");
        suffix_list.Add("of Equity");
        suffix_list.Add("of Exactness");
        suffix_list.Add("of Excellence");
        suffix_list.Add("of Excess");
        suffix_list.Add("of Exchange");
        suffix_list.Add("of Exhilaration");
        suffix_list.Add("of Expanse");
        suffix_list.Add("of Extension");
        suffix_list.Add("of Faith");
        suffix_list.Add("of Fangs");
        suffix_list.Add("of Fire");
        suffix_list.Add("of Flame");
        suffix_list.Add("of Focus");
        suffix_list.Add("of Foes");
        suffix_list.Add("of Foresight");
        suffix_list.Add("of Fortitude");
        suffix_list.Add("of Freezing");
        suffix_list.Add("of Frigidity");
        suffix_list.Add("of Frostbite");
        suffix_list.Add("of Glaciers");
        suffix_list.Add("of Glory");
        suffix_list.Add("of Grandeur");
        suffix_list.Add("of Greatness");
        suffix_list.Add("of Greed");
        suffix_list.Add("of Hail");
        suffix_list.Add("of Hardiness");
        suffix_list.Add("of Haste");
        suffix_list.Add("of Honor");
        suffix_list.Add("of Hope");
        suffix_list.Add("of Horizon");
        suffix_list.Add("of Hostility");
        suffix_list.Add("of Hurricanes");
        suffix_list.Add("of Ice");
        suffix_list.Add("of Icebergs");
        suffix_list.Add("of Ignition");
        suffix_list.Add("of Illness");
        suffix_list.Add("of Impalement");
        suffix_list.Add("of Impulse");
        suffix_list.Add("of Independence");
        suffix_list.Add("of Infection");
        suffix_list.Add("of Infirmity");
        suffix_list.Add("of Influence");
        suffix_list.Add("of Ingenuity");
        suffix_list.Add("of Insight");
        suffix_list.Add("of Intellect");
        suffix_list.Add("of Intent");
        suffix_list.Add("of Invigoration");
        suffix_list.Add("of Joviality");
        suffix_list.Add("of Judgment");
        suffix_list.Add("of Knowledge");
        suffix_list.Add("of Laceration");
        suffix_list.Add("of Lechery");
        suffix_list.Add("of Length");
        suffix_list.Add("of Lightning");
        suffix_list.Add("of Liveliness");
        suffix_list.Add("of Magnitude");
        suffix_list.Add("of Malady");
        suffix_list.Add("of Malevolence");
        suffix_list.Add("of Measure");
        suffix_list.Add("of Midnight");
        suffix_list.Add("of Might");
        suffix_list.Add("of Momentum");
        suffix_list.Add("of Monstrosity");
        suffix_list.Add("of Mortality");
        suffix_list.Add("of Numbness");
        suffix_list.Add("of Objection");
        suffix_list.Add("of Old");
        suffix_list.Add("of Omniscience");
        suffix_list.Add("of Opposition");
        suffix_list.Add("of Patience");
        suffix_list.Add("of Perfection");
        suffix_list.Add("of Perforation");
        suffix_list.Add("of Perjury");
        suffix_list.Add("of Pestilence");
        suffix_list.Add("of Precision");
        suffix_list.Add("of Premeditation");
        suffix_list.Add("of Pretense");
        suffix_list.Add("of Privilege");
        suffix_list.Add("of Projection");
        suffix_list.Add("of Prominence");
        suffix_list.Add("of Promise");
        suffix_list.Add("of Prosperity");
        suffix_list.Add("of Protest");
        suffix_list.Add("of Puncture");
        suffix_list.Add("of Purpose");
        suffix_list.Add("of Reach");
        suffix_list.Add("of Reclamation");
        suffix_list.Add("of Recovery");
        suffix_list.Add("of Recuperation");
        suffix_list.Add("of Refreshment");
        suffix_list.Add("of Refuge");
        suffix_list.Add("of Regard");
        suffix_list.Add("of Reinvention");
        suffix_list.Add("of Rejoicing");
        suffix_list.Add("of Rejuvenation");
        suffix_list.Add("of Reliance");
        suffix_list.Add("of Remoteness");
        suffix_list.Add("of Renewal");
        suffix_list.Add("of Repression");
        suffix_list.Add("of Reprieval");
        suffix_list.Add("of Resolution");
        suffix_list.Add("of Resolve");
        suffix_list.Add("of Restoration");
        suffix_list.Add("of Retaliation");
        suffix_list.Add("of Retribution");
        suffix_list.Add("of Revendication");
        suffix_list.Add("of Revenge");
        suffix_list.Add("of Reversal");
        suffix_list.Add("of Revival");
        suffix_list.Add("of Risk");
        suffix_list.Add("of Rivalry");
        suffix_list.Add("of Robustness");
        suffix_list.Add("of Scorching");
        suffix_list.Add("of Score");
        suffix_list.Add("of Searing");
        suffix_list.Add("of Seasons");
        suffix_list.Add("of Secrecy");
        suffix_list.Add("of Shadows");
        suffix_list.Add("of Sharpness");
        suffix_list.Add("of Shivering");
        suffix_list.Add("of Sickness");
        suffix_list.Add("of Singeing");
        suffix_list.Add("of Sleet");
        suffix_list.Add("of Slicing");
        suffix_list.Add("of Slush");
        suffix_list.Add("of Smoke");
        suffix_list.Add("of Snowflakes");
        suffix_list.Add("of Snowstorms");
        suffix_list.Add("of Sorrows");
        suffix_list.Add("of Span");
        suffix_list.Add("of Spikes");
        suffix_list.Add("of Stabbing");
        suffix_list.Add("of Stability");
        suffix_list.Add("of Starlight");
        suffix_list.Add("of Stretch");
        suffix_list.Add("of Stride");
        suffix_list.Add("of Strife");
        suffix_list.Add("of Strike");
        suffix_list.Add("of Struggle");
        suffix_list.Add("of Sturdiness");
        suffix_list.Add("of Sunrise");
        suffix_list.Add("of Sunset");
        suffix_list.Add("of Surplus");
        suffix_list.Add("of Survival");
        suffix_list.Add("of Symptoms");
        suffix_list.Add("of Talent");
        suffix_list.Add("of Talons");
        suffix_list.Add("of Target");
        suffix_list.Add("of Teeth");
        suffix_list.Add("of Tempests");
        suffix_list.Add("of the Badger");
        suffix_list.Add("of the Banished");
        suffix_list.Add("of the Bear");
        suffix_list.Add("of the Boar");
        suffix_list.Add("of the Deft");
        suffix_list.Add("of the Destructive");
        suffix_list.Add("of the Dexterous");
        suffix_list.Add("of the Dog");
        suffix_list.Add("of the Dove");
        suffix_list.Add("of the Eagle");
        suffix_list.Add("of the Effortless");
        suffix_list.Add("of the Falcon");
        suffix_list.Add("of the Feral");
        suffix_list.Add("of the Forgiven");
        suffix_list.Add("of the Fox");
        suffix_list.Add("of the Gull");
        suffix_list.Add("of the Haughty");
        suffix_list.Add("of the Hawk");
        suffix_list.Add("of the Heron");
        suffix_list.Add("of the Honed");
        suffix_list.Add("of the Hunter");
        suffix_list.Add("of the Jarred");
        suffix_list.Add("of the Jolted");
        suffix_list.Add("of the Leopard");
        suffix_list.Add("of the Lion");
        suffix_list.Add("of the Looter");
        suffix_list.Add("of the Nimble");
        suffix_list.Add("of the Oppressive");
        suffix_list.Add("of the Owl");
        suffix_list.Add("of the Panther");
        suffix_list.Add("of the Parasite");
        suffix_list.Add("of the Pillager");
        suffix_list.Add("of the Plunderer");
        suffix_list.Add("of the Predator");
        suffix_list.Add("of the Proud");
        suffix_list.Add("of the Provoked");
        suffix_list.Add("of the Rabid");
        suffix_list.Add("of the Raider");
        suffix_list.Add("of the Ram");
        suffix_list.Add("of the Raven");
        suffix_list.Add("of the Redeemed");
        suffix_list.Add("of the Savage");
        suffix_list.Add("of the Serpent");
        suffix_list.Add("of the Shaken");
        suffix_list.Add("of the Shocked");
        suffix_list.Add("of the Slayer");
        suffix_list.Add("of the Sparrow");
        suffix_list.Add("of the Speedy");
        suffix_list.Add("of the Spry");
        suffix_list.Add("of the Startled");
        suffix_list.Add("of the Swift");
        suffix_list.Add("of the Thief");
        suffix_list.Add("of the Unbridled");
        suffix_list.Add("of the Untamed");
        suffix_list.Add("of the Venomous");
        suffix_list.Add("of the Wild");
        suffix_list.Add("of the Wolf");
        suffix_list.Add("of the Zapped");
        suffix_list.Add("of Thorns");
        suffix_list.Add("of Threat");
        suffix_list.Add("of Thunder");
        suffix_list.Add("of Torment");
        suffix_list.Add("of Transcendence");
        suffix_list.Add("of Transience");
        suffix_list.Add("of Truth");
        suffix_list.Add("of Tusks");
        suffix_list.Add("of Twilight");
        suffix_list.Add("of Urgency");
        suffix_list.Add("of Valor");
        suffix_list.Add("of Vastness");
        suffix_list.Add("of Velocity");
        suffix_list.Add("of Vengeance");
        suffix_list.Add("of Vibrancy");
        suffix_list.Add("of Vigilance");
        suffix_list.Add("of Vindication");
        suffix_list.Add("of Virtue");
        suffix_list.Add("of Virulence");
        suffix_list.Add("of Vitality");
        suffix_list.Add("of Wealth");
        suffix_list.Add("of Winter");
        suffix_list.Add("of Wisdom");
        suffix_list.Add("of Wounding");
        suffix_list.Add("of Youth");
        suffix_list.Add("of Marc");
        suffix_list.Add("of 42");

        return suffix_list;
    }
}
