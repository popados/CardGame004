
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

    //******** EVERYTHING RECURSIVELY LOOPS IN HANDSELECTION! ********
    //Objects/Logic/Stuff needed for TCG Battle System:
    //Card[x] -- templates done
    //Deck[x] - shuffling done
    //Hand[x] - idea is to remove from shuffled[deck.Count-1] and add to hand list
    //drawCards[x] - need to refactor into methods that call the lists after they are made
    //Play Area[x] -- remove from hand and add to play area(no larger than 5)
    //Graveyard[x] -- list is made
    //player avatar card[x] -- using card to create a commander maybe have mana attached to the commander? like player.maxMana++
    //enemy avatar card[x] -- ^^
    //hand selection[x]
    //mana and mana count[x]
    //attack conditions[] --
    //turns[x] -- error in turn logic that doesnt always reset turn after endturn method
    //--REQUIRES => player, enemy, hand, shuffled, field, graveyard
    //---> something is added/removed/changed in these <---
    //---> have a function that holds each turn action
    //--> <start turn> <show mana> <show enemy & player hp> <show field> <create hand> <draw>
    //---> <play card> <mana up> <end turn>
    //might try to create a new method that uses 1-5 and test issues with recursion
    //i think its the endturn doesnt break into anything so it doesnt know where to find the while loop unless i cycle
    //card lists[]
//hand selection
//TODO
//build new card objects
//build object files for each card
//each object will have buttons associated with them and states(?)
//if i do states I can click on the card for the method
//
//add phases and 




//create hand
//mana
//show hp
//show field
//play card
//resolve field(?) make everything attack
//end > loop > mana up
//have to send mana to allow cards to be cast
//+1 mana each turn
//
//will exit when i set playerTurn to false
//if the player picks a card && has no mana >> go to end turn
//must call playerTurn method again
//
//use commander card to track the numbers i want to use?
//after hand selection i need field selection
//
//at 0 mana end turn and loop back to draw until enemy health is 0
//



namespace CardGame3
{
   
    public abstract class Card
    {
        //variables for cards
        public string CardName { get; set; }
        public string CardDescription { get; set; }
        public string AbilityDescription { get; set; }
        public string CardType { get; set; }
        public int Attack { get; set; }
        public int Health { get; set; }
        public int Cost { get; set; }
        public int maxMana { get; set; }
        public int currentMana { get; set; }
        public int playerTurnCount { get; set; }
        public bool playerTurn { get; set; }
        public bool isDead { get; set; }
        public bool summonSickness { get; set; }
        public bool isCreature { get; set; }

        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        SpriteFont arial;
        private Color _backgroundColor = Color.CornflowerBlue;
        private List<GameObject> gameObjects;
        //constructor for cards with default values
        //all cards are created as Card card = new CardName();
        //all commented out code between class and constructor in inheirented classes is for saving
        public Card()
        {
            CardName = "Card Name";
            CardDescription = "Card Description";
            AbilityDescription = "N/A";
            CardType = "Creature or Spell";
            Attack = 0;
            Health = 0;
            Cost = 0;
            isCreature = false;
            summonSickness = false;
        }
        public void Update()
        {

        }
        public void Draw(SpriteBatch spriteBatch) {
            spriteBatch.Begin();
            spriteBatch.DrawString(arial, "Display Cards: " , new Vector2(925, 0), Color.Black);
            spriteBatch.DrawString(arial, "Card Name: ", new Vector2(250, 50), Color.Black);
            spriteBatch.End();
        }
        public override string ToString()
        {
            return ":--" + CardName + "--:";
            //+ "\t Mana Cost: " + Cost
        }
        //public void createButton(ContentManager content) {
        //    var buttons =
        //        new Button(content.Load<Texture2D>("Assets/button"), content.Load<SpriteFont>("Fonts/Font"))
        //        {
        //            Position = new Vector2(0, 0),
        //            Text = "" + CardName,
        //        };
        //}

        public void printCard()
        {
            Console.WriteLine("Card: " + CardName +
                 "\n Description: " + CardDescription +
                "\n Ability: " + AbilityDescription +
                "\n Type: " + CardType +
                "\n Attack: " + Attack +
                "\n Health: " + Health +
                "\n Cost: " + Cost +
                "\n Just summoned: " + summonSickness);
            Console.WriteLine();
            //Console.ReadKey();
        }
        public virtual void dealDamage(Card target)
        {
            target.Health -= Attack;
            Console.WriteLine(CardName + " attacked for {0} damage", Attack);
            //could nest my if statements here
            //each creature is summoned > summonedSickness
            //ability function?? could over ride an empty ability
            //i want it to go like this player sel > card > field > ability > attack > end
            //i have sel > card > field > attack > end
            //each card can have an ability that checks field area
            //i.e fire drake gains +1/+1 atk/hp if (card.cardName = fire draco)
            //
        }
        //most of these need to rely on the card triggering the effect
        //could check field and if > creature && has effect
        //

        //enum each type maybe to make an easy property to read for the card
        //creature damage[x]
        //spell damage[x]
        //aura[] -- spell damage doesnt work
        //call[] -- additional summon from hand
        //defender[] -- blocker
        //first strike[] -- only attack creature && if summoned = true
        //force[] -- return creature card to hand
        //hyper[] -- creature ignores summoning sickness
        //last will[] -- effect trigger in graveyard
        //mute[] -- removes effects of creature
        //overkill[] -- defender destroyed deals damage to its hp
        //overpower[] -- destroy defenders immediately
        //rally[] -- additional summon from deck
        //ressurect[] -- happen from graveyard
        //ritual[] -- play cost to do effect
        //unstoppable[] -- can attack directly

    }
    public class ImpCard : Card
    {
        //string CardName = "Imp";
        //string CardDescription = "Totally not a Warlock pet.";
        //string AbilityDescription = "N/A";
        //string CardType = "Creature";
        //int Attack = 3;
        //int Health = 1;
        //int Cost = 1;
        public ImpCard()
        {
            CardName = "Imp";
            CardDescription = "Totally not a Warlock pet.";
            AbilityDescription = "N/A";
            CardType = "Creature";
            Attack = 3;
            Health = 1;
            Cost = 1;
            isCreature = true;
            isDead = false;
            summonSickness = false;
            //nothing but an attack
        }
        public override void dealDamage(Card target)
        {
            target.Health -= Attack;
        }
        public void printName() {
        }
    }
    public class LittleDraco : Card
    {
        //string CardName = "Little Draco";
        //string CardDescription = "Small Dragon.";
        //string AbilityDescription = "N/A";
        //string CardType = "Creature";
        //int Attack = 1;
        //int Health = 3;
        //int Cost = 1;
        public LittleDraco()
        {
            CardName = "Little Draco";
            CardDescription = "Small Dragon.";
            AbilityDescription = "N/A";
            CardType = "Creature";
            Attack = 1;
            Health = 3;
            Cost = 1;
            isCreature = true;
            isDead = false;
            summonSickness = false;
            //nothing will use card name for fire drake

        }
    }
    public class SpiritOFire : Card
    {
        //string CardName = "Spirit Of Fire";
        //string CardDescription = "Its the spirit of da fire, mon.";
        //string AbilityDescription = "N/A";
        //string CardType = "Creature";
        //int Attack = 3;
        //int Health = 4;
        //int Cost = 2;
        public SpiritOFire()
        {
            CardName = "Spirit Of Fire";
            CardDescription = "Its the spirit of da fire, mon.";
            AbilityDescription = "N/A";
            CardType = "Creature";
            Attack = 3;
            Health = 4;
            Cost = 2;
            isCreature = true;
            isDead = false;
            summonSickness = false;
            //if spirit fire dies(last will) {1 damage}
        }
    }
    public class FireDrake : Card
    {
        //string CardName = "Fire Drake";
        //string CardDescription = "Big Big Dragon.";
        //string AbilityDescription = "+1/+1 for each Little Draco in play.";
        //string CardType = "Creature";
        //int Attack = 5;
        //int Health = 3;
        //int Cost = 3;
        public FireDrake()
        {
            CardName = "Fire Drake";
            CardDescription = "Big Big Dragon.";
            AbilityDescription = "+1/+1 for each Little Draco in play.";
            CardType = "Creature";
            Attack = 5;
            Health = 3;
            Cost = 3;
            isCreature = true;
            isDead = false;
            summonSickness = false;
            //for each (cardName fire drake) +1/+1 atk/def
        }
    }
    public class FireBall : Card
    {
        //string CardName = "Fireball";
        //string CardDescription = "Fire in your face.";
        //string AbilityDescription = "Deal 1 damage to target creature/commander.";
        //string CardType = "Spell";
        //int Attack = 0;
        //int Health = 0;
        //int Cost = 1;
        public FireBall()
        {
            CardName = "Fireball";
            CardDescription = "Fire in your face.";
            AbilityDescription = "Deal 2 damage to target creature/commander.";
            CardType = "Spell";
            Attack = 2;
            Health = 0;
            Cost = 1;
            isCreature = false;
            summonSickness = false;
        }
    }
    public class FlameStrike : Card
    {
        //string CardName = "Flamestrike";
        //string CardDescription = "Fire strikes the earth.";
        //string AbilityDescription = "1 damage three times to random enemies.";
        //string CardType = "Spell";
        //int Attack = 0;
        //int Health = 0;
        //int Cost = 3;
        public FlameStrike()
        {
            CardName = "Flamestrike";
            CardDescription = "Fire strikes the earth.";
            AbilityDescription = "1 Damage to three creatures.";
            CardType = "Spell";
            Attack = 1;
            Health = 0;
            Cost = 2;
            isCreature = false;
            //for each card in field area list [i] = random ran for index//
            //add enemy to list
            //no summon sickness for spells
        }
    }
    public class WildFire : Card
    {
        //string CardName = "Wildfire";
        //string CardDescription = "Uncontrollable flames.";
        //string AbilityDescription = "Deal 2 damage to enemy creatures and commanders.";
        //string CardType = "Spell";
        //int Attack = 0;
        //int Health = 0;
        //int Cost = 2;
        public WildFire()
        {
            CardName = "Wildfire";
            CardDescription = "Uncontrollable flames.";
            AbilityDescription = "Deal 2 damage to all creatures and commanders.";
            CardType = "Spell";
            Attack = 2;
            Health = 0;
            Cost = 3;
            isCreature = false;
            //no summon sickness for spells
            //for each field area // etc //etc
        }
    }
    public class FireAvatar : Card
    {
        public FireAvatar()
        {
            CardName = "Atria, the Phoenix of Rebirth";
            CardDescription = "Commander of Fire. Edge and all.";
            AbilityDescription = "I AM THE COMMANDER! HAhaAhaA.";
            CardType = "Hero/Avatar";
            Attack = 0;
            Health = 15;
            Cost = 0;
            maxMana = 5;
            currentMana = 1;
            playerTurnCount = 0;
            playerTurn = false;
            isCreature = false;
            //no summon sickness for spells
        }
    }
    public class WaterAvatar : Card
    {
        public WaterAvatar()
        {
            CardName = "Celiana, Siren of the Sea";
            CardDescription = "Commander of Water. She gotchu swimming.";
            AbilityDescription = "I AM THE COMMANDER! HAhaAhaA.";
            CardType = "Hero/Avatar";
            Attack = 0;
            Health = 15;
            Cost = 0;
            maxMana = 0;
            isCreature = false;
            //no summon sickness for spells
        }
    }
}


//function to create cards and add to a list?
//now that ive got my switch statements written as functions i can use them here 
//
//turns[] -- error in turn logic that doesnt always reset turn after endturn method
//--REQUIRES => player, enemy, hand, shuffled, field, graveyard
//---> something is added/removed/changed in these <---
//---> have a function that holds each turn action
//---> <start turn> <show mana> <show enemy & player hp> <show field> 
//---> <create hand> <draw> <play card> <mana up> <end turn>

//~~~~STEPS TO DO FOR TCG~~~//~~NOTES INCLUDED IN THIS~~//
//Create Deck object x
//create player object that takes inputs for other objects x
//find out what variables x
//i need to figure out a curve for 21 cards with the 7 cards
//3 of each card x
//create a hand x
//create a field x
//create a graveyard x
//each turn: draw > main phase(play cards to field) > attack phase(move to field from graveyard) > end turn
//loop turn until a player is below 0 health

//start creating program here
//for a card game the steps i need are
//create deck x
//create hand x
//select card from hand x
//play card x
//end turn x

////
//ways of creating a deck
//hard code the deck of 21 with specific cards and use loops to make multiples
//i need to put the cards into a list and then create a shuffle loop to display 3 random card names 
//to hard code the deck i need to add the number of cards at cost and duplicates
//21 cards in a deck 
//3 of each card
//
//create the cards that make the deck
//7 cards and 3 of each
//chose to create each card individually
//now I need to to shuffle the deck
////
///
//
//turn based system
//use card for the object constructor for both the player and the target
//steps to take for a single turn
//show player and enemy health and mana
//draw[x]
//select card[x]
//play card[x]
//show field(use field)[]
//select field card[]
//end turn[x]



//first loop is while player or enemy health is above 0 keep creating turns
//second loop that adds one mana to the avatar per turn to a max of 5(maybe iterate after each turn with isMaxMana)
//

//->if creature summonedSickness = false 
//-- ask if they want to attack
//->if spell cast it or go back to hand
//->if creature select to play or go back to hand
//-->same steps for player 2

//show player health and mana crystals(have 1 at the start, mana++ each looping turn to a max of 5) 
//have main loop be while (enemy.hp || player.hp > 0)  { // do logic}
//inside the main loop have a while (mana < 5) { mana++; }
//conditions of player.draw == true && player.playCard == true && player.endTurn??
//or give player options and use conditions to say playing this card isnt possible?
//

//maybe do a turn one bool
//one single turn is draw > pick > play > show field > pick > attack > end
//Second turn > automate the steps with the idea that the AI will play one > two > three mana costs
//OR I can do player turn and have player input
//

//everything is in the handselection
//my logic sends the card selected to the field
//create the loop to go through the program and adds mana
//make sure all my objects and properties allow for each method to work
//loop until health
//add each card properties as methods that check what object is in the fieldarea and plays
//

//Ideas to create cards for monogame
//Everything the same in the card
//Add buttons to each card to call when I select the card in the hand
//Create Deck with one of each card


//Add cards to hand
//Select using hand buttons(1 for each card in hand)
// for each card in deck
// add(handSize) to hand
// for each card in hand
// var button for card
//