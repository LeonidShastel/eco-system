<?php

class Database
{
    private $host = "thelax67.beget.tech";
    private $db_name = "thelax67_ecosys";
    private $username = "TK&oBj75";
    private $password = "thelax67_ecosys";
    public $conn;

    public function getConnection(){

        $this->conn = null;

        try {
            $this->conn = mysqli_connect($this->host, $this->db_name, $this->username, $this->password);
        } catch(mysqli_sql_exception $exception){
            echo "Connection error: " . $exception->getMessage();
        }

        return $this->conn;
    }
}