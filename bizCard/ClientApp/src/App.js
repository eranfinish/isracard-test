import React, { Component } from 'react';
import { Route } from 'react-router';
import { Layout } from './components/Layout';
import { Home } from './components/Home';
import { FetchData } from './components/FetchData';
import { Counter } from './components/Counter';
import axios from 'axios';

import './custom.css'

export default class App extends Component {
  static displayName = App.name;
     userDetails = () => {
                axios.get("http://localhost/Card-API/api/user/GetDetails/12").then(
                    (response) => {

                        console.log(response.data);
                    })

            }
    render() {

        this.userDetails();
        return (
        
      <Layout>
        <Route exact path='/' component={Home} />
        <Route path='/counter' component={Counter} />
        <Route path='/fetch-data' component={FetchData} />
      </Layout>
    );
  }
}
