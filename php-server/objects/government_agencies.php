<?php

include_once $_SERVER['DOCUMENT_ROOT'] . '/eco-system/government_agencies/read.php';
include_once $_SERVER['DOCUMENT_ROOT'] . '/eco-system/government_agencies/readGosOne.php';
include_once $_SERVER['DOCUMENT_ROOT'] . '/eco-system/government_agencies/delete.php';
include_once $_SERVER['DOCUMENT_ROOT'] . '/eco-system/government_agencies/create.php';
include_once $_SERVER['DOCUMENT_ROOT'] . '/eco-system/government_agencies/update.php';
include_once $_SERVER['DOCUMENT_ROOT'].'/eco-system/government_agencies/readGos.php';

class GovernmentAgencies
{
    private $method,$urlData,$formData;

    public function __construct($method, $urlData, $formData){
        $this->method = $method;
        $this->urlData = $urlData;
        $this->formData = $formData;
    }

    public function sendResponse(){
        if ($this->method === "GET" && !empty($this->urlData[0]) && !empty($this->urlData[1]))
            readGosOne($this->urlData[0],$this->urlData[1]);
        else if ($this->method === "GET" && !empty($this->urlData[0]))
            readGos($this->urlData[0]);
        else if ($this->method === "GET")
            read();
        else if ($this->method === 'POST')
            create($this->formData);
        else if($this->method==='PUT'&&!empty($this->urlData[0]))
            update($this->urlData[0],$this->formData);
        else if($this->method==='DELETE'&&!empty($this->urlData[0]))
            delete($this->urlData[0]);
        else {
            header('HTTP/1.0 404 Bad Request');
            echo json_encode(array(
                'status'=>false,
                'message'=>'Bad Request'
            ));
        }
    }
}