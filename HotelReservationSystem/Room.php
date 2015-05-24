<?php
/**
 * Created by PhpStorm.
 * User: Nikolova
 * Date: 10/21/14
 * Time: 4:18 PM
 */

//namespace HotelReservatonSystem ;
//include "Reservation.php" ;
require_once("Reservation.php");

class Room implements iReservable {
    private $reservations;
    private $hasRestroom;
    private $hasBalcony;
    private $bedCount;
    private $roomNumber;
    private $extras;
    private $price;
    private $roomType;


    function __construct($roomNumber, $price, $reservations, $roomType,
        $hasRestroom, $hasBalcony, $bedCount, $extras) {

        $this->reservations = $reservations;
        $this->roomType = $roomType ;
        $this->hasRestroom = $hasRestroom ;
        $this->hasBalcony = $hasBalcony ;
        $this->bedCount = $bedCount ;
        $this->roomNumber = $roomNumber ;
        $this->extras = $extras ;
        $this->price = $price ;
    }

    public function getHasRestroom() {
        return $this->hasRestroom;
    }

    public function getHasBalcony() {
        return $this->hasBalcony;
    }

    public function getBedCount() {
        return $this->bedCount;
    }

    public function getRoomNumber() {
        return $this->roomNumber;
    }

    public function getExtras() {
        return $this->extras;
    }

    public function getPrice() {
        return $this->price;
    }
    public function getRoomType() {
        return $this->roomType;
    }
    public function addReservation(Reservation $reservation) {
        $unsuccessfulBooking = 'invalid data of your reservation';
        if (gettype($reservation) != "object") {
            return $unsuccessfulBooking;
        } else {
            if (empty($this->reservations)) {
                $success = array_push($this->reservations, $reservation);
                return $success;
            }
            foreach ($this->reservations as $bookedReservation) {
                $startDateNewReservation = strtotime($reservation->getStartDate());
                $endDateNewReservation = strtotime($reservation->getEndDate());
                $startDateBooked = strtotime($bookedReservation->getStartDate());
                $endDateBooked = strtotime($bookedReservation->getEndDate());
                $startInPeriod = $startDateNewReservation >= $startDateBooked && $startDateNewReservation <= $endDateBooked;
                $endInPeriod = $endDateNewReservation >= $startDateBooked && $endDateNewReservation <= $endDateBooked;

                if ($startInPeriod == true || $endInPeriod == true
                    || ($startDateNewReservation <= $startDateBooked && $endDateNewReservation >= $endDateBooked)) {
                    return "Already have a booking for that period!";
                } else {
                    $success = array_push($this->reservations, $reservation);
                    return $success;
                }
            }
        }
    }


    public function removeReservation(Reservation $reservation) {
        $key = array_search($reservation, $this->reservations);
        array_splice($this->reservations, $key, 1);
    }
}