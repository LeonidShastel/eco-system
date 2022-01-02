<?php

include_once $_SERVER['DOCUMENT_ROOT'].'/eco-system/config/database.php';

function update($id, $formData){
    $database = new Database();
    $db = $database->getConnection();

    $title = isset($formData['title']) ? "'".$formData['title']."'" : "`title`";
    $user_id = isset($formData['user_id']) ? "'".$formData['user_id']."'" : "`user_id`";
    $user_name = isset($formData['user_name']) ? "'".$formData['user_name']."'" : "`user_name`";
    $user_address = isset($formData['user_address']) ? "'".$formData['user_address']."'" : "`user_address`";
    $query = "UPDATE `government_agencies` SET `title`=".$title.", `user_id` = ".$user_id.", `user_name`=".$user_name.", `user_address`=".$user_address." WHERE `id` = '$id'";
    mysqli_query($db, $query);

    if(mysqli_error($db)){
        http_response_code(404);

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