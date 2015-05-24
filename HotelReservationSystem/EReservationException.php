<?php

class EReservationException  extends Exception{
    public function __construct($paramName) {
        parent::__construct("The room is reserved for this date: $paramName", 101);
    }
} 