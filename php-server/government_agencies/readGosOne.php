<?php

include_once $_SERVER['DOCUMENT_ROOT'].'/eco-system/config/database.php';


function readGosOne($call_number, $id){
    $database = new Database();
    $db = $database->getConnection();
    $call = mysqli_query($db, "SELECT * FROM `government_agencies` WHERE (`id` = '$id') AND (`call_number`='$call_number')");

    if(mysqli_num_rows($call)===0){
        http_response_code(404);

        echo json_encode(array(
            'status'=>false,
            'message'=>'Call not found'
        ));

        return;
    }

    $call = mysqli_fetch_assoc($call);

    echo json_encode(array(
        'message'=>'ok',
        'status'=>true,
        'data'=>$call
    ));
}