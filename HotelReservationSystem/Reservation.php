<?php
/**
 * Created by PhpStorm.
 * User: Nikolova
 * Date: 10/21/14
 * Time: 4:25 PM
 */

class Reservation {
    private  $startDate;
    private  $endDate;
    private $guest;

    function __construct($startDate, $endDate, $guest){
        $this->setStartDate($startDate);
        $this->endDate = $endDate ;
        $this->guest = $guest ;
    }

    public  function getStartDate(){
        return date("d-m-Y", $this->$startDate) ;
    }
    public function setStartDate($otherStartDate){

       // $someDate = strtotime($otherStartDate) ;
        $this->startDate = $otherStartDate;
    }
    public function getEndDate(){
        return $this->$endDate ;
    }
    public function setEndDate($otherEndDate){
        $this->$endDate = strtotime($otherEndDate) ;
    }
    public function getGuest(){
        return $this->guest ;
    }
    public function setGuest($otherGuest){
        $this->guest = $otherGuest->Guest ;
    }
    function __toString()
    {
        return "Reservation($this->startDate, $this->endDate, $this->guest)";
    }
} 