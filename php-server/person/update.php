<?php

include_once $_SERVER['DOCUMENT_ROOT'].'/eco-system/config/database.php';

function update($id, $formData){
    $database = new Database();
    $db = $database->getConnection();

    $lastname = isset($formData['lastname']) ? "'".$formData['lastname']."'" : "`lastname`";
    $firstname = isset($formData['firstname']) ? "'".$formData['firstname']."'" : "`firstname`";
    $patronymic = isset($formData['patronymic']) ? "'".$formData['patronymic']."'" : "`patronymic`";
    $phone = isset($formData['phone']) ? "'".$formData['phone']."'" : "`phone`";
    $date_of_birth = isset($formData['date_of_birth']) ? "'".$formData['date_of_birth']."'" : "`date_of_birth`";
    $address = isset($formData['address']) ? "'".$formData['address']."'" : "`address`";
    $place_of_work = isset($formData['place_of_work']) ? "'".$formData['place_of_work']."'" : "`place_of_work`";

    mysqli_query($db, "UPDATE `users` SET `lastname`=".$lastname.", `firstname`=".$firstname.", `patronymic`=".$patronymic.",`phone`=".$phone.",`date_of_birth`=".$date_of_birth.",`address`=".$address.",`place_of_work`=".$place_of_work." WHERE `id`='$id'");

    if(mysqli_error($db)){
        http_response_code(503);

        echo json_encode(array(
            'status'=>false,
            'message'=>mysqli_error($db)
        ));

        return;
    }

    echo json_encode(array(
        'message'=>'ok',
        'status'=>true,
        'id'=>$id,
        'data'=>$formData
    ));
}