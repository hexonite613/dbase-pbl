<?php
 
        $connect = mysqli_connect("","","","") or die("connection fail");
 
 
        $id=$_GET[id];
        $pw=hash('sha256',$_GET[pw]);
        $name=$_GET[name];
        $addr=$_GET[addr];
        $phonenum=$_GET[phonenum];
        $birthday=$_GET[birthday];
        $email=$_GET[email];
 
 
        $query = "insert into user (id, password, name, addr, birthday, email, phonenum, push, type) values ('$id', '$pw','$name', '$addr','$birthday', '$email','$phonenum','N', 'normal')";
 
 
        $result = $connect->query($query);
 

        if($result) {
        ?>      <script>
                alert('가입 되었습니다.');
                location.replace("../login.html");
                </script>
 
<?php   }
        else{
?>              <script>
                        
                        alert("fail");
                        alert("관리자에게 문의하세요")
                </script>
<?php   }
 
        mysqli_close($connect);
?>