<?php
/**
 * Created by PhpStorm.
 * User: Nikolova
 * Date: 10/21/14
 * Time: 4:15 PM
 */
interface iReservable {
    function addReservation(Reservation $reservation);
    function removeReservation(Reservation $reservation) ;
} 