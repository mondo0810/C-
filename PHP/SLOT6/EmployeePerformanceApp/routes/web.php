<?php

use Illuminate\Support\Facades\Route;
use App\Http\Controllers\EmployeeController;
use App\Http\Controllers\AttendanceController;


Route::get('/', [EmployeeController::class, 'performanceSummary']);
Route::get('/checkin', [AttendanceController::class, 'showCheckinForm'])->name('checkin.show');
Route::post('/check-in', [AttendanceController::class, 'checkIn'])->name('checkin.submit');
