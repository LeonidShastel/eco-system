<?php

include_once $_SERVER['DOCUMENT_ROOT'].'/eco-system/config/database.php';

function create($formData){
    $database = new Database();
    $db = $database->getConnection();

    $lastname = $formData['lastname'];
    $firstname = $formData['firstname'];
    $patronymic = $formData['patronymic'];
    $phone = $formData['phone'];
    $date_of_birth = $formData['date_of_birth'];
    $address = $formData['address'];
    $place_of_work = $formData['place_of_work'];

    mysqli_query($db, "INSERT INTO `users` (`id`,`lastname`,`firstname`,`patronymic`,`phone`,`date_of_birth`,`address`,`place_of_work`) VALUES (NULL,'$lastname', '$firstname', '$patronymic','$phone','$date_of_birth', '$address', '$place_of_work')");

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