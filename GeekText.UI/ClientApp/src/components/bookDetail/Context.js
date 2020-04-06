﻿import React, { Component, useEffect } from "react";
import axios from 'axios';
import { useState } from "react";

const BookContext = React.createContext();
//Provider
//Consumer
class BookProvider extends Component
{

    state = {
        books: [],
        bookDetail: JSON.parse(localStorage.getItem('book')),
        booksOfAuthor: JSON.parse(localStorage.getItem('bookA'))
    };

   
    async componentDidMount() {
        this.populateBooksData();
       
    }

    getItem = id => {
        const book = this.state.books.find(item => item.id === id);
        return book;

    };
   


    
    handleDetail = id => {
        const product = this.getItem(id);
        this.setState(()=>{
            return { bookDetail: product }
        }, () => {
                localStorage.setItem('book', JSON.stringify(this.state.bookDetail))
        });
        
    };

    populateBooksofAuthorData = id => {
        let x = id;
        console.log(id);
        const url = "http://localhost:5000/api/authors/booksOfAuthor/" + x;
        axios.get(url).then(response => {
            const book = response.data;

            this.setState(() => {
                return { booksOfAuthor: book }
            }, () => {
                    localStorage.setItem('bookA', JSON.stringify(this.state.booksOfAuthor))
            });

        })
    } 
   
    populateBooksData =() => {
        axios.get("http://localhost:5000/api/books/GetBooks").then(response => {
            this.setState({
                books: response.data
            })
        })
    } 


   

   
    render() {
        return (
            <BookContext.Provider
                value={{
                   ...this.state,
                    handleDetail: this.handleDetail,
                    populateBooksofAuthorData: this.populateBooksofAuthorData
                }}
            >
                {this.props.children}
            </BookContext.Provider>
        );
    }
}

const BookConsumer = BookContext.Consumer;

export { BookProvider, BookConsumer };