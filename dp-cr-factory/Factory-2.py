class Card:
    def create_card(self):
        pass

class GoldCard(Card):
    def create_card(self):
        return "Gold Card Created"

class SilverCard(Card):
    def create_card(self):
        return "Silver Card Created"

class PlatinumCard(Card):
    def create_card(self):
        return "Platinum Card Created"

class CardFactory:
    def get_card(self, card_type):
        if card_type == "Gold":
            return GoldCard()
        elif card_type == "Silver":
            return SilverCard()
        elif card_type == "Platinum":
            return PlatinumCard()
        else:
            return None

# Client code
if __name__ == "__main__":
    card_factory = CardFactory()
    card = card_factory.get_card("Gold")
    print(card.create_card())

    card = card_factory.get_card("Silver")
    print(card.create_card())
    
    card = card_factory.get_card("Platinum")
    print(card.create_card())