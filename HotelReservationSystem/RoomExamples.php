<?php
/**
 * Created by PhpStorm.
 * User: Nikolova
 * Date: 10/21/14
 * Time: 5:02 PM
 */
//namespace HotelReservationSystem ;

require_once("Guest.php");
require_once("Reservation.php");
require_once("iReservable.php");
require_once("Room.php");
require_once("SingleRoom.php");
//require_once("BookingManager.php");

$guestOne = new Guest("maria","nikolova",1) ;
$reservationOne = new Reservation("12345","23456",$guestOne);
//echo $reservationOne ;

$room = new SingleRoom(1408, 99);
$guest = new Guest("Svetlin", "Nakov", 8003224277);
$startDate = date("24.10.2014");
$endDate = date("26.10.2014");
$reservation = new Reservation($startDate, $endDate, $guest);
$room = new SingleRoom(1408, 99);
$guest = new Guest("Svetlin", "Nakov", 12);
$startDate = date("24.10.2014");
$endDate = date("26.10.2014");
$reservation = new Reservation($startDate, $endDate, $guest);

echo $reservation;

