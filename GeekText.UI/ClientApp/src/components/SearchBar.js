import React from "react";
import { Grid } from "@material-ui/core";
import { FaShoppingCart, FaHeart, FaSearch } from "react-icons/fa";
import FavoriteIcon from "@material-ui/icons/Favorite";
import AccountCircleIcon from "@material-ui/icons/AccountCircle";
import CartBar from "./ShoppingCart/CartBar";
import MenuBookIcon from '@material-ui/icons/MenuBook';

export default class SearchBar extends React.Component {
  state = {
    cartItemsTotal: 0,
  };
  componentWillMount() {
    const cartItemsTotal = JSON.parse(localStorage.getItem("cartItemsTotal"));
    if (cartItemsTotal) {
      this.setState({ cartItemsTotal });
    }
  }

  shouldComponentUpdate() {
    const cartItemsTotal = JSON.parse(localStorage.getItem("cartItemsTotal"));
    if (cartItemsTotal) {
      this.setState({ cartItemsTotal });
    }
  }

  renderSearchBarWithCartAmount() {
    let account_buttons = this.props.user ? (
      <Grid item>
        <FavoriteIcon htmlColor="#ec407a" fontSize="large" />
      </Grid>
    ) : null;
    let account_path = this.props.user ? "account" : "login";

    return (
      <>
        <Grid
          container
          direction="row"
          justify="center"
          alignItems="center"
          spacing={1}
        >
          
          <Grid item md={2}>
            <a href={"/"}>
              <h2>GeekText</h2>
            </a>
          </Grid>        
          <Grid item md={8}>
            {/* TEMP SEARCH BAR  */}
            <div className="searchBar">
              <input
                type="text"
                className="search"
                placeholder="Search for a book"
              />
              <button className="searchButton">
                <FaSearch />
              </button>
            </div>
            </Grid>
                <Grid item>
                    <a href={"/books" }>
                        <MenuBookIcon color="primary" fontSize="large" />
                    </a>
                </Grid>               
          <Grid item>
            <a href={"/" + account_path}>
              <AccountCircleIcon color="primary" fontSize="large" />
            </a>
          </Grid>
          <Grid item>
            <CartBar></CartBar>
          </Grid>
          {account_buttons}
        </Grid>
        
      </>
    );
  }

  render() {
    return this.renderSearchBarWithCartAmount();
  }
}
