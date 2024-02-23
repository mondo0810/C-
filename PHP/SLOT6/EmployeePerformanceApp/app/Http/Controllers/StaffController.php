<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;

class StaffController extends Controller
{
    public function index()
    {
        // Logic của phương thức index
        return view('admin.index');
    }
}
