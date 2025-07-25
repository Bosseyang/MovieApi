﻿using MovieApi.Models.Entities;
using MovieApi.Validations;
using System.ComponentModel.DataAnnotations;

namespace MovieApi.Models.DTOs;
//POST
public class MovieCreateDto
{
    [Required(ErrorMessage = "Title is a required field.")]
    public string Title { get; set; } = string.Empty;
    [Range(1900, 2025)]
    public int Year { get; set; }
    //TODO: Normalize later?
    [Required]
    [MaxLength(255, ErrorMessage = "Max length is 255.")]
    public string Genre { get; set; } = string.Empty;
    [Range(45, 300)]
    public int Duration { get; set; }

    //Navigation prop
    //[Required]
    public MovieDetailCreateDto MovieDetails { get; set; } = new();
}
