<?php
class PizzaObject{
    public $naam;
    public $prijs;
    public $aantal;
    
    public function totaalPrijs() {
        return $this->$prijs * $this->aantal;
    }
    
    public function setVariablen($n, $p, $a) {
        $this->naam = $n;
        $this->prijs = $p;
        $this->aantal = $a;
    }
    
    public function show(){
        return "Pizza: " . $this->naam . " " . $this->aantal . " x " . $this->prijs;
    }
}
?>