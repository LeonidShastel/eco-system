<?php

include_once $_SERVER['DOCUMENT_ROOT'].'/eco-system/config/database.php';


function readOne($id){
    $database = new Database();
    $db = $database->getConnection();

    $user = mysqli_query($db, "SELECT * FROM `users` WHERE `id` = '$id'");

    if(mysqli_num_rows($user)===0){
        http_response_code(404);

        echo json_encode(array(
            'status'=>false,
            'message'=>'User not found'
        ));

        return;
    }

    $user = mysqli_fetch_assoc($user);

    echo json_encode(array(
        'method'=>'ok',
        'status'=>true,
        'data'=>$user
    ));
}