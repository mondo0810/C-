<!DOCTYPE html>
<html>

<head>
    <title>Dashboard</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f2f2f2;
        }

        .container {
            max-width: 800px;
            margin: 0 auto;
            padding: 20px;
            background-color: #fff;
            border-radius: 5px;
            box-shadow: 0 2px 5px rgba(0, 0, 0, 0.1);
        }

        h1 {
            text-align: center;
        }

        .welcome-message {
            text-align: center;
            margin-top: 20px;
            font-size: 20px;
        }
    </style>
</head>

<body>
    <div class="container">
        <h1>Dashboardr</h1>
        <div class="welcome-message">
            <?php
            session_start();
            if ($_SESSION['username'] == "admin") {
                echo "Welcome admin đến với trang quản trị";
            } else {
                echo "Welcome " . $_SESSION['username'] . " đến với trang member";
            }
            ?>
        </div>
    </div>
</body>

</html>