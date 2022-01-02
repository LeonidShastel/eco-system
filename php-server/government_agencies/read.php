<?php

include_once $_SERVER['DOCUMENT_ROOT'].'/eco-system/config/database.php';

function read(){

    $database = new Database();
    $db = $database->getConnection();

    try {
        $calls = mysqli_query($db, "SELECT * FROM `government_agencies`");
    }
    catch (mysqli_sql_exception $exception){
        echo $exception->getMessage();
    }

    $calls_list = [];
    while ($call = mysqli_fetch_assoc($calls)){
        $calls_list[] = $call;
    }

    echo json_encode(array(
        'message'=>'ok',
        'status'=>true,
        'data'=>$calls_list
    ));
}