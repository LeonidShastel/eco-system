<?php

include_once $_SERVER['DOCUMENT_ROOT'].'/eco-system/person/read.php';
include_once $_SERVER['DOCUMENT_ROOT'].'/eco-system/person/readOne.php';
include_once $_SERVER['DOCUMENT_ROOT'].'/eco-system/person/delete.php';
include_once $_SERVER['DOCUMENT_ROOT'].'/eco-system/person/create.php';
include_once $_SERVER['DOCUMENT_ROOT'].'/eco-system/person/update.php';
class Person
{
    private $method,$urlData,$formData;

    public function __construct($method, $urlData, $formData){
        $this->method = $method;
        $this->urlData = $urlData;
        $this->formData = $formData;
    }

    public function sendResponse()
    {
        if ($this->method === "GET" && !empty($this->urlData[0]))
            readOne($this->urlData[0]);
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