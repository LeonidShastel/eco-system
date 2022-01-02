<?php

header("Access-Control-Allow-Origin: *");
header("Content-Type: application/json; charset=UTF-8");

ini_set('error_reporting', E_ALL);
ini_set('display_errors', 1);
ini_set('display_startup_errors', 1);

$method = $_SERVER['REQUEST_METHOD'];
$params = explode('/',$_GET['q']);
$type = $params[0];

switch ($type) {
    case "users":
        include_once $_SERVER['DOCUMENT_ROOT'].'/eco-system/objects/person.php';
        $person = new Person($method,array_slice($params,1), getFormData($method));
        $person->sendResponse();
        break;
    case "government_agencies":
        include_once $_SERVER['DOCUMENT_ROOT'].'/eco-system/objects/government_agencies.php';
        $mec = new GovernmentAgencies($method, array_slice($params,1), getFormData($method));
        $mec->sendResponse();
        break;
}

function getFormData($method) {

    // GET или POST: данные возвращаем как есть
    if ($method === 'GET') return $_GET;
    // PUT, PATCH или DELETE
    return json_decode(file_get_contents('php://input'),true);
}
