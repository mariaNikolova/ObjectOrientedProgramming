<?php
/**
 * Created by PhpStorm.
 * User: Nikolova
 * Date: 10/21/14
 * Time: 4:52 PM
 */

//namespace HotelReservatonSystem;


class Guest {
    private $firstName ;
    private $lastName ;
    private $id ;

    function __construct($firstName, $lastName, $id){
        $this->firstName = $firstName ;
        $this->lastName = $lastName ;
        $this->id = $id ;
    }

    public function getFirstName(){
        return $this->firstName ;
    }
    public function setFirstName($otherFirstName){
        $this->firstName = $otherFirstName ;
    }
    public function getLastName(){
        return $this->lastName ;
    }
    public function setLastName($otherLastName){
        $this->lastName= $otherLastName ;
    }
    public function getId(){
        return $this->id ;
    }
    public function setId($otherId){
        $this->id = $otherId ;
    }
    function __toString()
    {
        return "Guest($this->firstName, $this->lastName, $this->id)";
    }
} 