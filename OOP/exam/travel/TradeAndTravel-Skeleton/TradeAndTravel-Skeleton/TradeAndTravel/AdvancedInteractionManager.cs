﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TradeAndTravel
{
    public class AdvancedInteractionManager : InteractionManager
    {
        public AdvancedInteractionManager() :
            base()
        {
        }
        protected override Item CreateItem(string itemTypeString, string itemNameString, Location itemLocation, Item item)
        {
            switch (itemTypeString)
            {
                case "weapon":
                    item = new Weapon(itemNameString, itemLocation);
                    break;
                case "wood":
                    item = new Wood(itemNameString, itemLocation);
                    break;
                case "iron":
                    item = new Iron(itemNameString, itemLocation);
                    break;
                default: 
                    return base.CreateItem( itemTypeString,  itemNameString,  itemLocation,  item);
            }
            return item;    
        }
        protected override Location CreateLocation(string locationTypeString, string locationName)
        {
            switch (locationTypeString)
            {
                case "forest":
                    return new Forest(locationName);
                case "mine":
                    return new Mine(locationName);
                default:
                    return base.CreateLocation(locationTypeString, locationName);
            }
        }
        protected override void HandlePersonCommand(string[] commandWords, Person actor)
        {
            switch (commandWords[1])
            {
                case "gather":
                    this.handleGatherInteraction(actor, commandWords[2]);
                    break;
                case "craft":
                    this.handleCraftInteraction(actor, commandWords[2], commandWords[3]);
                    break;
                default:
                    base.HandlePersonCommand(commandWords, actor);
                    break;
            }
        }

        private void handleCraftInteraction(Person actor, string craftemItemType, string craftedItemName)
        {
            switch (craftemItemType)
            {
                case "armor":
                    this.CraftArmor(actor, craftedItemName);
                    break;
                case "weapon":
                    this.CraftWeapon(actor, craftedItemName);
                    break;
                default:
                    break;
            }
        }

        private void CraftWeapon(Person actor, string craftedItemName)
        {
            var actorInventory = actor.ListInventory();
            if (actorInventory.Any((item) => item.ItemType == ItemType.Iron)&&
                actorInventory.Any((item) => item.ItemType == ItemType.Wood))
            {
                this.AddToPerson(actor, new Weapon(craftedItemName));
            }
        }

        private void CraftArmor(Person actor, string craftedItemName)
        {
            var actorInventory = actor.ListInventory();
            if (actorInventory.Any((item) => item.ItemType == ItemType.Iron))
            {
                this.AddToPerson(actor, new Armor(craftedItemName));
            }
        }

        private void handleGatherInteraction(Person actor, string gatheredItemName)
        {
            var gatheringLocation = actor.Location as IGatheringLocation;
            if (gatheringLocation != null)
            {
                if (actor.ListInventory().Any((item) => item.ItemType == gatheringLocation.RequiredItem))
                {
                    var producedItem = gatheringLocation.ProduceItem(gatheredItemName);
                    this.AddToPerson(actor, producedItem);
                }
            }
        }
        protected override Person CreatePerson(string personTypeString, string personNameString, Location personLocation)
        {
            Person p = null;
            switch (personTypeString)
            {
                case "merchant":
                    p = new Merchant(personNameString, personLocation);
                    break;
                default:
                    p = base.CreatePerson(personTypeString, personNameString, personLocation);
                    break;
            }
            return p;
        }
    }
}
