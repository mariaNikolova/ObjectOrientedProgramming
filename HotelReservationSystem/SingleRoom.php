<?php
/**
 * Created by PhpStorm.
 * User: Nikolova
 * Date: 10/21/14
 * Time: 6:45 PM
 */
require_once("RoomType.php") ;

class SingleRoom extends Room {
    function __construct($roomNumber, $price) {
        parent::__construct($roomNumber, $price,$reservations = [],
            $roomType=RoomType::Standart, $hasRestroom = 1, $balcony = 0,
            $bedCount = 1, $extras = "TV, air-conditioner");
    }

    public function __toString() {
        return "Single room:{$this->getRoomNumber()} with price: {$this->getPrice()}, "
        . " room type: {$this->getRoomType()},extras: {$this->getExtras()})";
    }
} 