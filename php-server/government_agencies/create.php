<?php

include_once $_SERVER['DOCUMENT_ROOT'].'/eco-system/config/database.php';

function create($formData){
    $database = new Database();
    $db = $database->getConnection();

    $call_number = $formData['call_number'];
    $title = $formData['title'];
    $user_id = $formData['user_id'];
    $user_name = $formData['user_name'];
    $user_address = $formData['user_address'];
    $call_time = date("Y-m-d H:i:s");

    mysqli_query($db, "INSERT INTO `government_agencies` (`id`,`call_number`,`title`, `user_id`, `user_name`,`user_address`,`call_time`) VALUES (NULL,'$call_number','$title','$user_id', '$user_name','$user_address','$call_time')");

    if(mysqli_error($db)){
        echo json_encode(array(
            'status'=>false,
            'message'=>mysqli_error($db)
        ));

        return;
    }

    http_response_code(201);

    echo json_encode(array(
        'message'=>'ok',
        'status'=>true,
        'id'=>mysqli_insert_id($db),
        'data'=>$formData
    ));
}