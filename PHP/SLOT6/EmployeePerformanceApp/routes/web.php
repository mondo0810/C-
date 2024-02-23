<?php

use Illuminate\Support\Facades\Route;
use App\Http\Controllers\EmployeeController;
use App\Http\Controllers\AttendanceController;
use App\Http\Controllers\AdminController;
use Illuminate\Support\Facades\Auth;
use App\Http\Controllers\StaffController;

Route::get('/', [EmployeeController::class, 'performanceSummary']);
Route::get('/checkin', [AttendanceController::class, 'showCheckinForm'])->name('checkin.show');
Route::post('/check-in', [AttendanceController::class, 'checkIn'])->name('checkin.submit');

Auth::routes();

Route::get('/home', [App\Http\Controllers\HomeController::class, 'index'])->name('home');

Route::get('/admin', [AdminController::class, 'index'])->middleware('checkrole:admin');
Route::get('/staff', [StaffController::class, 'index'])->middleware('checkrole:staff');
