<?php
// Dit PHP bestand bevat het PIZZA object.
// Dit Object zorgt er voor dat we gemakkelijk lijsten van pizzas kunnen maken en fetchen.
// Hierdoor hoeven we niet al te veel spaghettie code te gebruiken op bestellingen.php
class PizzaObject{
    // Public variablen van dit object.
    public $naam;
    public $prijs;
    public $aantal;
    
    // Totaalprijs bereken.
    public function totaalPrijs() {
        return $this->$prijs * $this->aantal;
    }
    
    // Zet de variablen met behulp van 1 functie.
    public function setVariablen($n, $p, $a) {
        $this->naam = $n;
        $this->prijs = $p;
        $this->aantal = $a;
    }
    
    // Laat een string zien met de naam, het aantal en de totaalprijs van de pizzas.
    public function show(){
        return "Pizza: " . $this->naam . " " . $this->aantal . " x " . $this->prijs;
    }
}
?>