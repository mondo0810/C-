<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Model;

class Category extends Model
{
    protected $fillable = [
        'category_name',
    ];

    public function users()
    {
        return $this->hasManyThrough(User::class, 'user_roles', 'category_id', 'user_id');
    }

    public function articles()
    {
        return $this->hasMany(Article::class, 'category_id');
    }
}
