<?php

include_once $_SERVER['DOCUMENT_ROOT'].'/eco-system/config/database.php';

function delete($id){
    $database = new Database();
    $db = $database->getConnection();

    mysqli_query($db, "DELETE FROM `users` WHERE `id`='$id'");

    if(mysqli_error($db)){
        echo json_encode(array(
            'status'=>false,
            'message'=>mysqli_error($db)
        ));

        return;
    }

    echo json_encode(array(
        'message'=>'deleted',
        'status'=>true,
        'data'=>$id,
    ));
}