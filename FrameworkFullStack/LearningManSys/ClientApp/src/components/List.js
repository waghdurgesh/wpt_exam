import React, { Component } from 'react';
import { Link } from 'react-router-dom';

export class List extends Component {
  static displayName = List.name;

  constructor(props) {
    super(props);
    this.state = { forecasts: [], loading: true };
  }

  componentDidMount() {
    this.getTrainingData();
  }

  static renderTrainingTable(forecasts) {
    return (
      <div className='col-md-6'>
        <table className="table table-striped" aria-labelledby="tableLabel">
          <thead>
            <tr>
              <th>Id</th>
              <th>Topic</th>
              <th>Description</th>
              {/* <th>Faculty</th> */}
              {/* <th>Location</th> */}
              <th> </th>
            </tr>
          </thead>
          <tbody>
            {forecasts.map(Item =>
              <tr key={Item.id}>
                <td>{Item.id}</td>
                <td>{Item.topic}</td>
                <td>{Item.description}</td>
                {/* <td>{Item.faculty}</td> */}
                {/* <td>{Item.location}</td> */}
                <td>
                  <Link to={"/training/Details/" + Item.id}><button type="button" className='btn btn-info'
                    onClick>Details</button>
                  </Link>
                </td>
                <td>
                <Link to={"/training/getlist"}><button type="button" className='btn btn-danger'
                  onClick>Delete</button>
                </Link>
              </td>
              </tr>
            )}
          </tbody>
        </table>
      </div>
    );
  }

  render() {
    let contents = this.state.loading
      ? <p><em>Loading...</em></p>
      : List.renderTrainingTable(this.state.forecasts);

    return (
      <div>
        <h1 id="tableLabel">Training List</h1>
        <p>This component demonstrates fetching data from the server for Training List.</p>
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
