using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Into_The_Void_Character_Gen
{
    class Human
    {
        public static List<String> Nationality = new List<String>();
        public static List<String> freeColonies = new List<String>();
        public static List<String> secondColonies = new List<String>();

        public static List<String> freeColoniesCarrers = new List<String>();
        public static List<String> secondColoniesCarrers = new List<String>();

        public static List<String> Earthborn = new List<String>();
        public static List<String> FirstExpansion = new List<String>();
        public static List<String> FrontierWorld = new List<String>();
        public static List<String> OrbitalString = new List<String>();
        public static List<String> JungleWorld = new List<String>();
        public static List<String> IceWorld = new List<String>();
        public static List<String> DesertWorld = new List<String>();
        public static List<string> MegaCity = new List<String>();

        public static List<List<string>> Flaws = new List<List<string>>();

        public void main()
        {
            Nationality.Add("Democratic Alliance of  Free Colonies");
            Nationality.Add("Second Wave Colonies");

            freeColonies.Add("Earthborn: Strength +1, Dexterity +1");
            freeColonies.Add("First Expansion Colony World: Resilience +1, Strength +1");
            freeColonies.Add("Frontier World: Willpower +1, Dexterity +1");
            freeColonies.Add("Orbital String Space Station: Intelligence +1, Willpower +1");

            secondColonies.Add("Jungle World: Willpower +1, Dexterity +1");
            secondColonies.Add(" Ice World: Resilience +1, Strength +1");
            secondColonies.Add("Desert World: Strength +1, Willpower +1");
            secondColonies.Add("Mega-City: Intelligence +1, Dexterity +1");

            Earthborn.Add("Big City Upbringing: Dexterity +1, Barter");
            Earthborn.Add("Rural Upbringing: Strength +1, Rover Operation");
            Earthborn.Add("High Society: Intelligence +1, Persuade");
            Earthborn.Add("Street Urchin: Willpower + 1, Hand to Hand");

            FirstExpansion.Add("Farm Life: Strength +1, Rover Operation");
            FirstExpansion.Add("Small City Upbringing: Resilience +1, Barter");
            FirstExpansion.Add("Frontier Town: Willpower +1, Always Prepared");
            FirstExpansion.Add("Science Outpost: Intelligence +1, Computer Specialist");

            FrontierWorld.Add("New Settler: Resilience +1, Exploration");
            FrontierWorld.Add("Mining Town: Strength +1, Underground Navigation");
            FrontierWorld.Add("Hub City: Intelligence +1, Persuasion");
            FrontierWorld.Add("Drifters: Willpower +1, Rover Operation");

            OrbitalString.Add("Aging Station: Willpower +1, Null G Movement");
            OrbitalString.Add("Industrial Platform: Strength +1, Repair");
            OrbitalString.Add("Orbital Dockyard: Intelligence +1, Starship Repair");
            OrbitalString.Add("Communications Hub: Dexterity +1, Communications and Sensors");

            JungleWorld.Add("Genetic Engineering Center: Resilience +1, Gene Tonic Creation and Application");
            JungleWorld.Add("Research Station: Intelligence +1, Always Prepared");
            JungleWorld.Add("Lumber Town: Strength +1, Pathfinding");
            JungleWorld.Add("Exploration Hub: Willpower +1, Exploration");

            IceWorld.Add("Genetic Engineering Center: Resilience +1, Gene Tonic Creation and Application");
            IceWorld.Add("Domed City: Dexterity +1, Underground Navigation");
            IceWorld.Add("Astronomy Outpost: Intelligence +1, Navigation");
            IceWorld.Add("Water Refinery: Strength +1, Environment Survival");

            DesertWorld.Add("Genetic Engineering Center: Resilience +1, Gene Tonic Creation and Application");
            DesertWorld.Add(" Mining City: Strength +1, Repair");
            DesertWorld.Add("Advanced Technology Center: Intelligence +1, Computer Specialist");
            DesertWorld.Add("Cave City: Dexterity +1, Underground Navigation");

            MegaCity.Add("Cybernetics Center: Resilience +1, Cybernetics Application and Repair");
            MegaCity.Add("Port District: Strength +1, Starship Repair");
            MegaCity.Add("Administration District: Intelligence +1, Persuasion");
            MegaCity.Add("Under-City: Dexterity +1, Small Arms");

            freeColoniesCarrers.Add("DAFC Military - Marines: Small Arms, Null G Movement, Basic Medicine");
            freeColoniesCarrers.Add("DAFC Military - Marines: Small Arms, Null G Movement, Basic Medicine");
            freeColoniesCarrers.Add("DAFC Military - Marines: Small Arms, Null G Movement, Basic Medicine");
            freeColoniesCarrers.Add("DAFC Military - Marines: Small Arms, Null G Movement, Basic Medicine");
            freeColoniesCarrers.Add("DAFC Military - Marines: Small Arms, Null G Movement, Basic Medicine");
            freeColoniesCarrers.Add("DAFC Military - Marines: Small Arms, Null G Movement, Basic Medicine");
            freeColoniesCarrers.Add("DAFC Military - Marines: Small Arms, Null G Movement, Basic Medicine");
            freeColoniesCarrers.Add("DAFC Military - Marines: Small Arms, Null G Movement, Basic Medicine");
            freeColoniesCarrers.Add("DAFC Military - Marines: Small Arms, Null G Movement, Basic Medicine");
            freeColoniesCarrers.Add("DAFC Military - Marines: Small Arms, Null G Movement, Basic Medicine");
            freeColoniesCarrers.Add("DAFC Military - Marines: Small Arms, Null G Movement, Basic Medicine");
            freeColoniesCarrers.Add("DAFC Military - Marines: Small Arms, Null G Movement, Basic Medicine");
            freeColoniesCarrers.Add("DAFC Military - Marines: Small Arms, Null G Movement, Basic Medicine");
            freeColoniesCarrers.Add("DAFC Military - Marines: Small Arms, Null G Movement, Basic Medicine");

            secondColoniesCarrers.Add("");
            secondColoniesCarrers.Add("");
            secondColoniesCarrers.Add("");
            secondColoniesCarrers.Add("");
            secondColoniesCarrers.Add("");
            secondColoniesCarrers.Add("");
            secondColoniesCarrers.Add("");
            secondColoniesCarrers.Add("");
            secondColoniesCarrers.Add("");
            secondColoniesCarrers.Add("");
            secondColoniesCarrers.Add("");
            secondColoniesCarrers.Add("");
            secondColoniesCarrers.Add("");
            secondColoniesCarrers.Add("");

            Details.CharacterList[0].Nationality = "Democratic Alliance of  Free Colonies";
            Details.CharacterList[0].Planet = "Earthborn: Strength +1, Dexterity +1";
            Details.CharacterList[0].Life = "Big City Upbringing: Dexterity +1, Barter";

            Update("update", Details.panel);

            foreach (Control ctl in Details.characterPanel.Controls)
            {
                switch (ctl.Name)
                {
                    case "Planet":
                        ctl.Text = "Planet: " + Details.CharacterList[0].Planet;
                        break;
                    case "Willpower":
                        ctl.Text = "Willpower: " + Details.CharacterList[0].WILL;
                        break;
                    case "Strength":
                        ctl.Text = "Strength: " + Details.CharacterList[0].STR;
                        break;
                    case "Resiliance":
                        ctl.Text = "Resiliance: " + Details.CharacterList[0].RES;
                        break;
                    case "Dexterity":
                        ctl.Text = "Dexterity: " + Details.CharacterList[0].DEX;
                        break;
                    case "Intelligence":
                        ctl.Text = "Intelligence: " + Details.CharacterList[0].INT;
                        break;
                    case "Perception":
                        ctl.Text = "Perception: " + Details.CharacterList[0].PER;
                        break;
                    case "Abilities":
                        foreach (string x in Details.CharacterList[0].Skills)
                        {
                            ctl.Text += x + "\n";
                        }
                        break;
                    case "Flaws":
                        foreach (string x in Details.CharacterList[0].Flaws)
                        {
                            ctl.Text += x + "\n";
                        }
                        break;
                }
            }
        }

        public void Update(string controller, Panel p)
        {
            var C1 = Details.CharacterList[0];

            if (controller == "Button")
            {
                p.Visible = false;
                Details.CareerPanel.Visible = true;
                return;
            }

            switch (C1.Planet)
            {
                case "Earthborn: Strength +1, Dexterity +1":
                    C1.STR ++;
                    C1.DEX ++;
                    break;
                case "First Expansion Colony World: Resilience +1, Strength +1":
                    C1.STR ++;
                    C1.RES ++;
                    break;
                case "Frontier World: Willpower +1, Dexterity +1":
                    C1.DEX ++;
                    C1.WILL++;
                    break;
                case "Orbital String Space Station: Intelligence +1, Willpower +1":
                    C1.WILL ++;
                    C1.INT ++;
                    break;
                case "Jungle World: Willpower +1, Dexterity +1":
                    C1.DEX ++;
                    C1.WILL ++;
                    break;
                case " Ice World: Resilience +1, Strength +1":
                    C1.STR ++;
                    C1.RES ++;
                    break;
                case "Desert World: Strength +1, Willpower +1":
                    C1.STR ++;
                    C1.WILL ++;
                    break;
                case "Mega-City: Intelligence +1, Dexterity +1":
                    C1.DEX ++;
                    C1.INT ++;
                    break;
            }

			switch(C1.Life)
			{
                case "Administration District: Intelligence +1, Persuasion":
                    C1.INT++;
                    C1.Skills.Add("Persuasion");
                    break;
                case "Advanced Technology Center: Intelligence +1, Computer Specialist":
                    C1.INT++;
                    C1.Skills.Add("Computer Specialist");
                    break;
                case "Aging Station: Willpower +1, Null G Movement":
                    C1.WILL++;
                    C1.Skills.Add("Null G Movement");
                    break;
                case "Astronomy Outpost: Intelligence +1, Navigation":
                    C1.INT++;
                    C1.Skills.Add("Navigation");
                    break;
                case "Big City Upbringing: Dexterity +1, Barter":
                    C1.DEX++;
                    C1.Skills.Add("Barter");
                    break;
                case "Cave City: Dexterity +1, Underground Navigation":
                    C1.DEX++;
                    C1.Skills.Add("Underground Navigation");
                    break;
                case "Communications Hub: Dexterity +1, Communications and Sensors":
                    C1.DEX++;
                    C1.Skills.Add("Communications and Sensors");
                    break;
                case "Cybernetics Center: Resilience +1, Cybernetics Application and Repair":
                    C1.RES++;
                    C1.Skills.Add("Cybernetics Application and Repair");
                    break;
                case "Domed City: Dexterity +1, Underground Navigation":
                    C1.DEX++;
                    C1.Skills.Add("Underground Navigation");
                    break;
                case "Drifters: Willpower +1, Rover Operation":
                    C1.WILL++;
                    C1.Skills.Add("Rover Operation");
                    break;
                case "Exploration Hub: Willpower +1, Exploration":
                    C1.WILL++;
                    C1.Skills.Add("Exploration");
                    break;
                case "Farm Life: Strength +1, Rover Operation":
                    C1.STR++;
                    C1.Skills.Add("Rover Operation");
                    break;
                case "Frontier Town: Willpower +1, Always Prepared":
                    C1.WILL++;
                    C1.Skills.Add("Always Prepared");
                    break;
                case "Genetic Engineering Center: Resilience +1, Gene Tonic Creation and Application":
                    C1.RES++;
                    C1.Skills.Add("Gene Tonic Creation and Application");
                    break;
                case "High Society: Intelligence +1, Persuade":
                    C1.INT++;
                    C1.Skills.Add("Persuade");
                    break;
                case "Hub City: Intelligence +1, Persuasion":
                    C1.INT++;
                    C1.Skills.Add("Persuasion");
                    break;
                case "Industrial Platform: Strength +1, Repair":
                    C1.STR++;
                    C1.Skills.Add("Repair");
                    break;
                case "Lumber Town: Strength +1, Pathfinding":
                    C1.STR++;
                    C1.Skills.Add("Pathfinding");
                    break;
                case "Mining City: Strength +1, Repair":
                    C1.STR++;
                    C1.Skills.Add("Repair");
                    break;
                case "Mining Town: Strength +1, Underground Navigation":
                    C1.STR++;
                    C1.Skills.Add("Underground Navigation");
                    break;
                case "New Settler: Resilience +1, Exploration":
                    C1.RES++;
                    C1.Skills.Add("Exploration");
                    break;
                case "Orbital Dockyard: Intelligence +1, Starship Repair":
                    C1.INT++;
                    C1.Skills.Add("Starship Repair");
                    break;
                case "Port District: Strength +1, Starship Repair":
                    C1.STR++;
                    C1.Skills.Add("Starship Repair");
                    break;
                case "Research Station: Intelligence +1, Always Prepared":
                    C1.INT++;
                    C1.Skills.Add("Always Prepared");
                    break;
                case "Rural Upbringing: Strength +1, Rover Operation":
                    C1.STR++;
                    C1.Skills.Add("Rover Operation");
                    break;
                case "Science Outpost: Intelligence +1, Computer Specialist":
                    C1.INT++;
                    C1.Skills.Add("Computer Specialist");
                    break;
                case "Small City Upbringing: Resilience +1, Barter":
                    C1.RES++;
                    C1.Skills.Add("Barter");
                    break;
                case "Street Urchin: Willpower +1, Hand to Hand":
                    C1.WILL++;
                    C1.Skills.Add("Hand to Hand");
                    break;
                case "Under-City: Dexterity +1, Small Arms":
                    C1.DEX++;
                    C1.Skills.Add("Small Arms");
                    break;
                case "Water Refinery: Strength +1, Environment Survival":
                    C1.STR++;
                    C1.Skills.Add(" Environment Survival");
                    break;
            }
            
        }
    }
}