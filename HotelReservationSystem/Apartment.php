<?php
/**
 * Created by PhpStorm.
 * User: Nikolova
 * Date: 10/21/14
 * Time: 7:00 PM
 */

class Apartment extends Room {
    function __construct($roomNumber, $price) {
        parent::__construct($roomNumber, $price,
            $reservations = [], $roomType = RoomType::Diamond, $hasRestroom = 1,
            $hasBalcony = 1,$bedCount= 4,
            $extras = "TV, air-conditioner, refrigerator, kitchen box, mini-bar, bathtub, free Wi-fi");
    }

    public function __toString() {
        return "Apartment: {$this->getRoomNumber()} with price: {$this->getPrice()},"
        . " room type: {$this->getRoomType()}, extras: {$this->getExtras()})";
    }
} 