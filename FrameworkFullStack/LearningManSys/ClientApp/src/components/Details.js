import React, { Component } from 'react';
import { Link } from 'react-router-dom';

export class Details extends Component {
  static displayName = Details.name;

  constructor(props) {
    super(props);
    this.state = { forecasts: [], loading: true };
  }

  componentDidMount() {
    this.getTrainingData();
  }

  static renderTrainingTable(forecasts) {
    return (
      <table className="table table-striped" aria-labelledby="tableLabel">
        <thead>
          <tr>
            <th>Id</th>
            <th>Topic</th>
            <th>Description</th>
            <th>Faculty</th>
            <th>Location</th>
          </tr>
        </thead>
        <tbody>
          {forecasts.map(Item =>
            <tr key={Item.id}>
              <td>{Item.id}</td>
              <td>{Item.topic}</td>
              <td>{Item.description}</td>
              <td>{Item.faculty}</td>
              <td>{Item.location}</td>
              
            </tr>
          )}
        </tbody>
      </table>
    );
  }

  render() {
    let contents = this.state.loading
      ? <p><em>Loading...</em></p>
      : Details.renderTrainingTable(this.state.forecasts);

    return (
      <div>
        <h1 id="tableLabel">Training Details</h1>
        <p>This component demonstrates fetching data from the server for Training Details.</p>
        {contents}
      </div>
    );
  }

  async getTrainingData() {
    const response = await fetch('/api/training/getlist');
    const data = await response.json();
    this.setState({ forecasts: data, loading: false });
  }
}
