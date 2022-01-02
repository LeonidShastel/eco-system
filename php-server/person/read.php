<?php

include_once $_SERVER['DOCUMENT_ROOT'].'/eco-system/config/database.php';

function read(){

    $database = new Database();
    $db = $database->getConnection();

    try {
        $users = mysqli_query($db, "SELECT * FROM `users`");
    }
    catch (mysqli_sql_exception $exception){
        echo  $exception->getMessage();
    }

    $users_list = [];
    while ($user = mysqli_fetch_assoc($users)){
        $users_list[] = $user;
    }

    echo json_encode(array(
        'message'=>'ok',
        'status'=>true,
        'data'=>$users_list
    ));
}